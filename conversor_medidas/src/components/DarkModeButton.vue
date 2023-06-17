<template>
    <label class="toggle">
        <span class="action d-flex justify-content-center">
            <input 
            type="checkbox" 
            :checked="(mode === 'dark') ? 'checked' : false" 
            @change="$emit('toggle')"
            />
            <div></div>
        </span>
    </label>    
</template>

<script>    
    export default {
        props: ['mode']
    }
</script>

<style scoped>
    span{
        user-select: none;
        cursor: pointer;
    }    
    .action input{
        appearance: none;
    }

    .action div{
        position: relative;
        width: 50px;
        height: 25px;
        background: #ddd;
        border-radius: 15px;
    }

    .action input:checked ~ div{
        background: #0988dd;
        transition: 0.3s;
    }

    .action div::before{
        content: '';
        position: absolute;
        top: 2.5px;
        left: 2.5px;
        width: 20px;
        height: 20px;
        border-radius: 10px;
        background: #fff;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        transition: 0.5s;
    }

    .action input:checked ~ div::before{
        left: calc(100% - 22.5px);
    }
</style>