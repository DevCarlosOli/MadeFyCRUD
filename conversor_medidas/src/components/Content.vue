<template>
    <div class="content d-flex justify-content-center align-items-center">
        <div class="container d-flex justify-content-center align-items-center">
            <form>
                <div class="row g-3 mb-3 d-flex justify-content-between align-items-center">
                    <div class="col-sm-5">
                        <label class="form-label">Digite o valor que deseja converter:</label>                    
                    </div>
                    <div class="col-sm-7">
                        <input type="text" class="form-control">
                    </div>                 
                </div>
                <div class="row g-3 mb-3 d-flex justify-content-between align-items-center">
                    <div class="col-sm-6">
                        <label class="form-label">Escolha unidade inicial e unidade de conversão:</label>
                    </div>                
                    <div class="col-sm-3">
                        <input type="text" class="form-control">
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control">
                    </div>  
                </div>   
                <div class="row g-3 mb-3 d-flex justify-content-center align-items-center">          
                    <div class="col-sm-auto">
                        <button type="submit" class="btn btn-primary">Converter</button>
                    </div>
                    <div class="col-sm-auto">
                        <input type="text" class="form-control">
                    </div>  
                </div>                             
            </form>
        </div>
    </div>            
</template>

<script>
    export default {
        props: ['mode']
    }
</script>

<style scoped>
    .content{
        height: 100%;
    }
    .container{
        margin: 0 auto;
        background: #d6d6d6;
        width: 800px;
        padding: 15px;
        border-radius: 20px;
        box-shadow: 8px 8px 10px rgba(0, 0, 0, 0.5);
        transition: 0.3s ease-in-out;
    }

    .dark .container{
        background: #15202B;
    }
</style>



