<template>
  <div id="something" class="d-flex flex-row">
    <div v-bind:class="'fork ' + round + length + location"><br /><br /></div>
    <div class="d-flex align-items-center" v-bind:class="roundline + length">
      <div v-bind:class="'line '"></div>
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
  margin-bottom: -20px;
}
.two161 {
  height: 106px;
  margin-top: 23px;
  margin-bottom: -20px;
}
.two162 {
  height: 106px;
  margin-top: 23px;
  margin-bottom: -20px;
}
.two163 {
  height: 106px;
  margin-top: 23px;
  margin-bottom: -20px;
}
.three160 {
  height: 208px;
  margin-bottom: -1px;
}
.three161 {
  height: 207px;
  margin-bottom: -3px;
}
.four160 {
  height: 411px;
  margin-top: 6px;
  margin-bottom: -20px;
}
.two150 {
  height: 112px;
  margin-top: 23px;
  margin-bottom: -1px;
}
.two151 {
  height: 110px;
  margin-top: 35px;
  margin-bottom: -13px;
}
.two152 {
  height: 113px;
  margin-top: 45px;
  margin-bottom: -24px;
}
.two153 {
  height: 90px;
  margin-top: 56px;
  margin-bottom: -10px;
}
.three150 {
  height: 206px;
  margin-bottom: -1px;
}
.three151 {
  height: 205px;
  margin-bottom: -2px;
}
.four150 {
  height: 411px;
  margin-top: 5vh;
}
.two140 {
  height: 117px;
  margin-top: 31px;
  margin-bottom: -10px;
}
.two141 {
  height: 119px;
  margin-top: 57px;
  margin-bottom: -25px;
}
.two142 {
  height: 114px;
  margin-top: 90px;
  margin-bottom: -43px;
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
  margin-bottom: -20px;
}
.two131 {
  height: 127px;
  margin-top: 73px;
  margin-bottom: -49px;
}
.two132 {
  height: 125px;
  margin-top: 115px;
  margin-bottom: -39px;
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
  margin-bottom: -13px;
}
.two121 {
  height: 140px;
  margin-top: 4px;
  margin-bottom: -11px;
}
.two122 {
  height: 138px;
  margin-top: 6px;
  margin-bottom: -12px;
}
.three120 {
  height: 274px;
  margin-top: 133px;
  margin-bottom: 20px;
}
.three121 {
  height: 0px;
  margin-top: 133px;
}
.four120 {
  height: 411px;
  margin-top: 39px;
}
.two110 {
  height: 145px;
  margin-top: 10px;
  margin-bottom: -23px;
}
.two111 {
  height: 146px;
  margin-bottom: -35px;
  margin-top: 23px;
}
.two112 {
  height: 127px;
  margin-top: 37px;
  margin-bottom: -30px;
}
.three110 {
  height: 273px;
  margin-top: 136px;
  margin-bottom: 14px;
}
.three111 {
  height: 0px;
}
.four110 {
  height: 411px;
  margin-top: 38px;
}
.two100 {
  height: 166px;
  margin-top: 19px;
  margin-bottom: -43px;
}
.two101 {
  height: 166px;
  margin-top: 73px;
  margin-bottom: -81px;
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
  margin-top: 39px;
}
.two90 {
  height: 174px;
  margin-top: 23px;
  margin-bottom: -56px;
}
.two91 {
  height: 184px;
  margin-top: 90px;
  margin-bottom: -116px;
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
  margin-top: 43px;
}
.two80 {
  height: 207px;
  margin-top: -29px;
  margin-bottom: -46px;
}
.two81 {
  height: 207px;
  margin-top: -29px;
  margin-bottom: -44px;
}
.three80 {
  height: 411px;
}

.two70 {
  height: 215px;
  margin-top: -22px;
  margin-bottom: -59px;
}
.two71 {
  height: 199px;
  margin-top: -3px;
  margin-bottom: -62px;
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
  margin-bottom: -156px;
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

.secondround16 {
  margin-top: 54px;
}
.thirdround16 {
  margin-top: 24px;
}

.secondround15 {
  margin-top: 27px;
}
.thirdround15 {
  margin-top: 27px;
}
.secondround14 {
  margin-top: 27px;
}
.thirdround14 {
  margin-top: 27px;
}
.secondround13 {
  margin-top: 27px;
}
.thirdround13 {
  margin-top: 27px;
}

.secondround12 {
  margin-top: 27px;
}
.thirdround12 {
  margin-top: 20px;
}

.secondround11 {
  margin-top: 27px;
}
.thirdround11 {
  margin-top: 20px;
}

.secondround10 {
  margin-top: 27px;
}
.thirdround10 {
  margin-top: 20px;
}

.secondround9 {
  margin-top: 27px;
}
.thirdround9 {
  margin-top: 20px;
}

.secondround8 {
  margin-top: 27px;
}
.thirdround8 {
  margin-top: 30px;
}
.secondround7 {
  margin-top: 27px;
}
.thirdround7 {
  margin-top: 30px;
}

.secondround6 {
  margin-top: 27px;
}
.thirdround6 {
  margin-top: 29px;
}

.secondround5 {
  margin-top: 32px;
}
.thirdround5 {
  margin-top: 20px;
}
.secondround4 {
  margin-top: 27px;
}
.secondround3 {
  margin-top: 27px;
}

.line {
  display: flex;
  border: 2px solid black;
  width: 3vw;
  height: 0vh;
}
</style>
