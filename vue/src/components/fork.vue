<template>
  <div id="something" class="d-flex flex-row">
    <div v-bind:class="'fork ' + round"><br /><br /></div>
    <div class="d-flex align-items-center">
      <div v-bind:class="'line ' + roundline"></div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["round", "roundline"],
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
  margin-top: 23px;
}
.three {
  height: 211px;
}
.four {
  height: 411px;
  margin-top: 5vh;
}
.sixteensecondround {
  margin-top: 54px;
}
.sixteenthirdround {
  margin-top: 64px;
}
.sixteenfourthround {
  margin-top: 27px;
}

.line {
  display: flex;
  border: 2px solid black;
  width: 3vw;
  height: 0vh;
}
</style>
