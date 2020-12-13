<template>
  <div id="something" class="d-flex flex-row">
    <div v-bind:class="'fork ' + round + length + location"><br /><br /></div>
    <div class="d-flex align-items-center">
      <div v-bind:class="'line ' + roundline"></div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["round", "roundline", "length", "location"],
};
</script>

<style>
.fork {
  border: 2px solid black;
  border-left: 0px;
  width: 100%;
}
.two160 {
  height: 106px;
  margin-top: 23px;
}
.two161 {
  height: 106px;
  margin-top: 23px;
}
.two162 {
  height: 106px;
  margin-top: 23px;
}
.two163 {
  height: 106px;
  margin-top: 23px;
}
.three160 {
  height: 208px;
}
.three161 {
  height: 207px;
}
.four160 {
  height: 411px;
  margin-top: 5vh;
}
.two150 {
  height: 112px;
  margin-top: 23px;
}
.two151 {
  height: 110px;
  margin-top: 35px;
}
.two152 {
  height: 113px;
  margin-top: 45px;
}
.two153 {
  height: 90px;
  margin-top: 56px;
}
.three150 {
  height: 206px;
}
.three151 {
  height: 205px;
}
.four150 {
  height: 411px;
  margin-top: 5vh;
}
.two140 {
  height: 117px;
  margin-top: 31px;
}
.two141 {
  height: 119px;
  margin-top: 57px;
}
.two142 {
  height: 114px;
  margin-top: 90px;
}
.two143 {
  height: 114px;
  margin-top: 90px;
  height: 1px;
  width: 63%;
  height: 0%;
}
.three140 {
  height: 213px;
  margin-top: 11px;
}
.three141 {
  height: 199px;
  margin-top: 22px;
}
.four140 {
  height: 411px;
  margin-top: 5vh;
}

.two130 {
  height: 129px;
  margin-top: 31px;
}
.two131 {
  height: 127px;
  margin-top: 73px;
}
.two132 {
  height: 125px;
  margin-top: 115px;
}
.two133 {
  border: 0px;
  height: 0px;
  margin-top: 23px;
}
.three130 {
  height: 212px;
  margin-top: 14px;
}
.three131 {
  height: 201px;
  margin-top: 26px;
}
.four130 {
  height: 411px;
  margin-top: 5vh;
}
.two120 {
  height: 106px;
  margin-top: 23px;
}
.two121 {
  height: 106px;
  margin-top: 23px;
}
.two122 {
  height: 106px;
  margin-top: 23px;
}
.three12 {
  height: 274px;
  margin-top: 133px;
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
  height: 410px;
}

.two6 {
  height: 106px;
  margin-top: 23px;
}
.three6 {
  height: 413px;
  margin-top: 11px;
}

.two5 {
  height: 106px;
  margin-top: 23px;
}
.three5 {
  height: 415px;
  margin-top: 13px;
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
