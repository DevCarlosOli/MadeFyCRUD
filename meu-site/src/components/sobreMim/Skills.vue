<template>
    <div>
        <h3>{{ msg }}</h3>
        <img class="img-fluid logo-skills" src="../../assets/html-logo.png" alt="Logo HTML">
        <img class="img-fluid logo-skills" src="../../assets/css-logo.png" alt="Logo CSS">
        <img class="img-fluid logo-skills" src="../../assets/js-logo.png" alt="Logo JavaScript">
        <img class="img-fluid logo-skills" src="../../assets/vue-logo.png" alt="Logo VueJs">
        <img class="img-fluid logo-skills" src="../../assets/csharp_logo.png" alt="Logo C-Sharp">
        <img class="img-fluid logo-skills" src="../../assets/postgresql-logo.png" alt="Logo PostgreSQL">
        <img class="img-fluid logo-skills" src="../../assets/corel-logo.png" alt="Logo CorelDRAW">
        <img class="img-fluid logo-skills" src="../../assets/photoshop-logo.png" alt="Logo PhotoShop">
    </div>
</template>

<script>
export default {
    name: 'Skills',
    data() {
        return {
            msg: 'Minhas Skills'
        }
    }
}
</script>

<style>
    .logo-skills{
        margin-left: 15px;
    }
</style>