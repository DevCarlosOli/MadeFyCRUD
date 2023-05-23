<template>
  <Banner />
  <PrincipaisDestaques />  
</template>

<script>
  import Banner from '../components/Banner.vue';
  import PrincipaisDestaques from '../components/PrincipaisDestaques.vue';

  export default{
    components: {
      Banner,
      PrincipaisDestaques
    }
  }
</script>
