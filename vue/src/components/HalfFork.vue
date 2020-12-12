<template>
     <div id="something" class="d-flex flex-row">
            <div class="fork-left d-flex flex-column ">
                <div class="left-top"></div>
                <div class="left-bottom"></div>
            </div>
            <div class="fork-right d-flex jusify-content-center">
                <div class="middle line"></div>
            </div>          
    </div>
</template>

<script>
export default {};
</script>

<style>
.left-bottom {
  border: 2px solid black;
  border-left: 0px;
  border-top: 0px;
  width: 100%;
  height: 100%;
  margin:2px
}
.fork-left{
    width: 50%;
}
.line {
  display: flex;
  border: 2px solid black;
  width: 3vw;
  height: 0vh;
  margin-bottom:2.5vh;
}

</style>