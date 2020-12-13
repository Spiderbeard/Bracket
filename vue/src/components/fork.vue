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
  height: 141px;
  margin-top: 4px;
}
.two121 {
  height: 140px;
  margin-top: 4px;
}
.two122 {
  height: 138px;
  margin-top: 6px;
}
.three120 {
  height: 274px;
  margin-top: 133px;
}
.three121 {
  height: 0px;
  margin-top: 133px;
}
.four120 {
  height: 411px;
  margin-top: 57px;
}
.two110 {
  height: 145px;
  margin-top: 10px;
}
.two111 {
  height: 146px;
  margin-top: 23px;
}
.two112 {
  height: 127px;
  margin-top: 37px;
}
.three110 {
  height: 273px;
  margin-top: 136px;
}
.three111 {
  height: 0px;
}
.four110 {
  height: 411px;
  margin-top: 57px;
}
.two100 {
  height: 166px;
  margin-top: 19px;
}
.two101 {
  height: 166px;
  margin-top: 73px;
}
.two102 {
  height: 0px;
  margin-top: 23px;
}
.three100 {
  height: 284px;
  margin-top: 139px;
}
.three101 {
  height: 0px;
}
.four100 {
  height: 411px;
  margin-top: 58px;
}
.two90 {
  height: 174px;
  margin-top: 23px;
}
.two91 {
  height: 175px;
  margin-top: 94px;
}
.two92 {
  height: 0px;
  margin-top: 23px;
}
.three90 {
  height: 281px;
  margin-top: 140px;
}
.three91 {
  height: 0px;
}
.four90 {
  height: 411px;
  margin-top: 56px;
}
.two80 {
  height: 207px;
  margin-top: -29px;
}
.two81 {
  height: 207px;
  margin-top: -29px;
}
.three80 {
  height: 411px;
}

.two70 {
  height: 215px;
  margin-top: -22px;
}
.two71 {
  height: 199px;
  margin-top: -3px;
}
.three70 {
  height: 410px;
}

.two60 {
  height: 276px;
  margin-top: 5px;
  margin-bottom: -135px;
}
.two61 {
  height: 0px;
  margin-top: 23px;
}
.three60 {
  height: 411px;
  margin-top: 15px;
}

.two50 {
  height: 289px;
  margin-top: 11px;
}
.two51 {
  height: 0px;
  margin-top: 23px;
}
.three50 {
  height: 410px;
  margin-top: 16px;
}

.two40 {
  height: 410px;
  margin-top: -130px;
  margin-bottom: -145px;
}

.two30 {
  height: 412px;
  margin-top: -120px;
  margin-bottom: -158px;
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
