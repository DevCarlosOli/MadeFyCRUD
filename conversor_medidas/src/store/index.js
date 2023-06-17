import { createStore } from 'vuex'

export default createStore({
  state: {
    medidas: [
      {
        id:1,
        name: "CM_MM",
        valor: 10
      },
      {
        id:2,
        name: "MM_CM",
        valor: 0.1
      }
    ],
  },
  mutations: {
  },
  getters: {
  },
  actions: {
  },
  modules: {
  }
})
