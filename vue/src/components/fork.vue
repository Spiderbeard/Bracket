<template>
  <div id="something" class="d-flex flex-row">
    <div v-bind:class="'fork ' + round"><br /><br /></div>
    <div class="d-flex align-items-center">
      <div class="line"></div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["round"],
};
</script>

<style>
.fork {
  border: 2px solid black;
  border-left: 0px;
  width: 100%;
}
.two {
  height: 106px;
  margin-top: 2vh;
}
.three {
  height: 211px;
}
.four {
  height: 411px;
  margin-top: 5vh;
}

.line {
  display: flex;
  border: 2px solid black;
  width: 3vw;
  height: 0vh;
  margin-bottom: 2.5vh;
}
</style>
