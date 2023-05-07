<template>
    <hr />
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <p id="footer">{{ msg }}</p>
            </div>
        </div>        
    </div>
</template>

<script>
export default {
    name: 'Footer',
    data() {
        return {
            msg: 'Site Pessoal - 2023'
        }
    },
}
</script>

<style>
#footer{
    text-align: center;
}
</style>