<template>
  <div id="something" class="d-flex flex-row">
    <div v-bind:class="'fork ' + round + length"><br /><br /></div>
    <div class="d-flex align-items-center">
      <div v-bind:class="'line ' + roundline"></div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["round", "roundline", "length"],
};
</script>

<style>
.fork {
  border: 2px solid black;
  border-left: 0px;
  width: 100%;
}
.two16 {
  height: 106px;
  margin-top: 23px;
}
.three16 {
  height: 211px;
}
.four16 {
  height: 411px;
  margin-top: 5vh;
}
.two15 {
  height: 106px;
  margin-top: 23px;
}
.three15 {
  height: 211px;
}
.four15 {
  height: 411px;
  margin-top: 5vh;
}
.two14 {
  height: 106px;
  margin-top: 23px;
}
.three14 {
  height: 211px;
}
.four14 {
  height: 411px;
  margin-top: 5vh;
}
.two13 {
  height: 106px;
  margin-top: 23px;
}
.three13 {
  height: 211px;
}
.four13 {
  height: 411px;
  margin-top: 5vh;
}
.two12 {
  height: 106px;
  margin-top: 23px;
}
.three12 {
  height: 211px;
}
.four12 {
  height: 411px;
  margin-top: 5vh;
}
.two11 {
  height: 106px;
  margin-top: 23px;
}
.three11 {
  height: 211px;
}
.four11 {
  height: 411px;
  margin-top: 5vh;
}
.two10 {
  height: 106px;
  margin-top: 23px;
}
.three10 {
  height: 211px;
}
.four10 {
  height: 411px;
  margin-top: 5vh;
}
.two9 {
  height: 106px;
  margin-top: 23px;
}
.three9 {
  height: 211px;
}
.four9 {
  height: 411px;
  margin-top: 5vh;
}
.two8 {
  height: 106px;
  margin-top: 23px;
}
.three8 {
  height: 211px;
}

.two7 {
  height: 106px;
  margin-top: 23px;
}
.three7 {
  height: 211px;
}

.two6 {
  height: 106px;
  margin-top: 23px;
}
.three6 {
  height: 211px;
}

.two5 {
  height: 106px;
  margin-top: 23px;
}
.three5 {
  height: 211px;
}

.two4 {
  height: 106px;
  margin-top: 23px;
}

.two3 {
  height: 106px;
  margin-top: 23px;
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
