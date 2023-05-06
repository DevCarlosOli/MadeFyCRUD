<template>
  <Header />  
  <SobreMim />
  <Footer />
</template>

<script>
import Header from './components/Header.vue'
import SobreMim from './components/sobreMim/SobreMim.vue'
import Footer from './components/Footer.vue'

export default {
  name: 'App',
  components: {
    Header,
    SobreMim,
    Footer
  }
}
</script>

<style>
*{
  margin: 0;
  padding: 0;
  font-family: Arial, Helvetica, sans-serif;
}
</style>
