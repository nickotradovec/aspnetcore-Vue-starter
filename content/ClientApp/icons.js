import fontawesome from '@fortawesome/fontawesome'
// Official documentation available at: https://github.com/FortAwesome/vue-fontawesome
import FontAwesomeIcon from '@fortawesome/vue-fontawesome'

// If not present, it won't be visible within the application. Considering that you
// don't want all the icons for no reason. This is a good way to avoid importing too many
// unnecessary things.
fontawesome.library.add(
  require('@fortawesome/fontawesome-free-solid/faEnvelope'),
  require('@fortawesome/fontawesome-free-solid/faGraduationCap'),
  require('@fortawesome/fontawesome-free-solid/faHome'),
  require('@fortawesome/fontawesome-free-solid/faList'),
  require('@fortawesome/fontawesome-free-solid/faSpinner'),
  require('@fortawesome/fontawesome-free-solid/faEdit'),
  require('@fortawesome/fontawesome-free-solid/faTrash'),
  require('@fortawesome/fontawesome-free-solid/faInfo'),
  require('@fortawesome/fontawesome-free-solid/faPlus'),
  require('@fortawesome/fontawesome-free-solid/faArrowRight'),
  require('@fortawesome/fontawesome-free-solid/faArrowRight'),
  //require('@fortawesome/fontawesome-free-solid/faUSD'),
  // Brands
  require('@fortawesome/fontawesome-free-brands/faFontAwesome'),
  require('@fortawesome/fontawesome-free-brands/faMicrosoft'),
  require('@fortawesome/fontawesome-free-brands/faVuejs')
)

export {
  FontAwesomeIcon
}
