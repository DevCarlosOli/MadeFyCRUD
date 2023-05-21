<template>
    <div>
        <h3>{{ msg }}</h3>
        <img class="img-fluid logo-skills" src="../../public/img/html-logo.png" alt="Logo HTML">
        <img class="img-fluid logo-skills" src="../../public/img/css-logo.png" alt="Logo CSS">
        <img class="img-fluid logo-skills" src="../../public/img/js-logo.png" alt="Logo JavaScript">
        <img class="img-fluid logo-skills" src="../../public/img/vue-logo.png" alt="Logo VueJs">
        <img class="img-fluid logo-skills" src="../../public/img/csharp_logo.png" alt="Logo C-Sharp">
        <img class="img-fluid logo-skills" src="../../public/img/postgresql-logo.png" alt="Logo PostgreSQL">
        <img class="img-fluid logo-skills" src="../../public/img/corel-logo.png" alt="Logo CorelDRAW">
        <img class="img-fluid logo-skills" src="../../public/img/photoshop-logo.png" alt="Logo PhotoShop">
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
        margin-right: 15px;
        margin-top: 10px;
        height: 80px;
        width: 80px;
    }
</style>