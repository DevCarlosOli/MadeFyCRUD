import { createApp } from 'vue'
import App from './App.vue'
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import { library } from '@fortawesome/fontawesome-svg-core'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'
import { faList, faCogs, faArrowCircleRight, faArrowCircleLeft,  } from '@fortawesome/free-solid-svg-icons'

library.add(faList)
library.add(faCogs)
library.add(faArrowCircleRight)
library.add(faArrowCircleLeft)

createApp(App)
.component('awesome', FontAwesomeIcon)
.mount('#app')
