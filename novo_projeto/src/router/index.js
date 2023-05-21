import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/sobreMim',
    name: 'sobreMim',
    component: () => import(/* webpackChunkName: "sobreMim" */ '../views/SobreMimView.vue')
  },
  {
    path: '/portfolio',
    name: 'portfolio',
    component: () => import(/* webpackChunkName: "portfolio" */ '../views/PortfolioView.vue')
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
