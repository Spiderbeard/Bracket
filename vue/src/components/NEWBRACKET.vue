<template>
    <div>
        <div class = "main Area">
            <div class="round1">
                <div class="matchMain">
                </div>
            </div>
            <div class="fork1">
                <fork/>                   
            </div>
            <div class="round2">
                <div class="matchMain">                        
                </div>
            </div>
            <div class="fork2">
                <fork/>
            </div>
            <div class="round3">
                <div class="matchMain">                       
                </div>
            </div>
            <div class="fork3">
                <fork/>
            </div>
            <div class="round4">
                <div class="matchMAin">                    
                </div>
            </div>
            <div class="winnerLine">
                <line/>
            </div>
            <div class="chamion">
                <div>Winnder </div>
            </div>
        </div>
   </div>
</template>
 
 <script>
 import fork from "@/components/fork"
 export default {
     components:{fork}
 
 }
 </script>
 
 <style>
 
 </style>