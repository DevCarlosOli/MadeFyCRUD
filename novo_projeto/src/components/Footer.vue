<template>
    <hr />
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <p id="footer">&copy; {{ msg }}</p>
            </div>
        </div>        
    </div>
</template>

<script>
export default {
    name: "Footer",
    data() {
        return {
            msg: '2023 - Carlos R. de Oliveira Filho'
        }
    },
}
</script>

<style scoped>
#footer{
    text-align: center;
}
</style>
  