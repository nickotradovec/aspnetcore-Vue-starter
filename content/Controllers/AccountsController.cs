using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Net.Http;
using System.Threading.Tasks;
using Ledger.DataObjects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ledger.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AccountList : Controller {

        [HttpGet ("[action]")]
        public async Task<IActionResult> AccountsList () {
            using (var db = new AppDb ()) {
                await db.Connection.OpenAsync ();
                var query = new AccountQuery (db);
                var result = await query.GetAllAccounts ();
                return new OkObjectResult (result);
            }
        }
    }

    [Route ("api/[controller]")]
    [ApiController]
    public class AccountManagement {

        [HttpGet ("{id}")]
        public async Task<IActionResult> GetAccountDetails ([FromQuery (Name = "id")] int id = 0) {
            using (var db = new AppDb ()) {
                await db.Connection.OpenAsync ();
                var query = new AccountQuery (db);
                var result = await query.GetAccount (id);
                if (result == null) { return new BadRequestResult (); }
                return new OkObjectResult (result);
            }
        }

        [HttpPost ("[action]")]
        public async Task<IActionResult> AddNewAccount (Account data) {

            data.SetStringsFromDates ();
            using (var db = new AppDb ()) {
                await db.Connection.OpenAsync ();
                var query = new AccountQuery (db);
                var result = await query.AddAccount (data.accountName, data.commence_string, data.cease_string, data.initialBalance);
                return new OkResult ();
            }
        }

        [HttpPost ("[action]")]
        public async Task<IActionResult> UpdateAccount (Account data) {

            data.SetStringsFromDates();
            using (var db = new AppDb ()) {
                await db.Connection.OpenAsync ();
                var query = new AccountQuery (db);
                var result = await query.UpdateAccount (data.accountId, data.accountName, data.commence_string, data.cease_string, data.initialBalance);
                return new OkResult ();
            }
        }
    }
}