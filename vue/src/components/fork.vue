<template>
  <div class="d-flex flex-row">
    <div class="fork"><br><br></div>
    <div class="d-flex align-items-end">
      <div class="line"></div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style>
.fork {
  border: 2px solid black;
  border-left: 0px;
  width: 100%;
  height: 100%;
  margin-top: 2vh;
  margin-bottom: 4vh;
}

.line {
  display: flex;
  border: 2px solid black;
  width: 3vw;
  height: 0vh;
  margin-bottom:2.5vh;
}
</style>
