<template>
  <div class="app" :class="mode">
    <Navbar :mode="mode" @toggle="toggle"/>
    <router-view :mode="mode" @toggle="toggle"/>
  </div>  
</template>

<script>
    import Navbar from '@/components/Navbar.vue'

    export default {
      data() {
        return {
          name: 'Conversor de Medidas',
          mode: 'light'
        }
      },
      components: {
        Navbar
      },
      methods: {
        toggle(){
          if(this.mode === "dark"){
            this.mode = "light"
          }
          else{
            this.mode = "dark"
          }
        }
      }
    }
</script>

<style>
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Roboto', sans-serif;
}

.app{
  width: 100%;
  height: 100vh;
  background: #f3f3f3;
  transition: background 0.3s  ease-in-out;
}

.dark{
  background: #2e2e2e;
  color: #fff;
}
</style>
