@import url('https://fonts.googleapis.com/css2?family=IBM+Plex+Mono:wght@500;600;700&family=Outfit:wght@400;500;600;700;800&display=swap');

/* =========================================================
   JYLEE — SEIRAN ISLAND SKIN V2
   Theme: SHO-Approved Paradise / Adults-Only Compliance Resort
   Requires: jylee-chub-framework-v19.css
   Activate with: <div class="jy-page jy-seiran">
   ========================================================= */


/* =========================================================
   THEME TOKENS
   ========================================================= */

body:has(.jy-page.jy-seiran){
  --jy-accent:#ff6f8f;
  --jy-accent-rgb:255,111,143;

  --jy-accent-2:#ffad66;
  --jy-accent-2-rgb:255,173,102;

  --jy-accent-3:#ffd38f;
  --jy-accent-3-rgb:255,211,143;

  --jy-accent-4:#ff3f72;
  --jy-accent-4-rgb:255,63,114;

  --jy-bg:#130813;
  --jy-panel:rgba(27,10,26,.91);
  --jy-panel-soft:rgba(42,15,38,.80);
  --jy-card:rgba(255,255,255,.035);

  --jy-border:rgba(255,173,102,.18);
  --jy-border-hot:rgba(255,111,143,.25);

  --jy-text:#fff5f7;
  --jy-text-soft:#e6cfd7;
  --jy-text-muted:#b796a3;
  --jy-title:#fff8f4;

  --jy-danger:#ff465f;
  --jy-danger-rgb:255,70,95;

  --jy-shadow:0 18px 44px rgba(0,0,0,.42);
  --jy-radius:20px;

  --jy-font-display:'Outfit','Segoe UI',system-ui,sans-serif;
  --jy-font-body:'Outfit','Segoe UI',system-ui,sans-serif;
  --jy-font-mono:'IBM Plex Mono','Consolas',monospace;
}


/* =========================================================
   CHUB NATIVE TAGLINE — SAFE HIDE
   Hides only the native bold tagline text, never the notes.
   ========================================================= */

body:has(.jy-page.jy-seiran)
.ant-col-lg-18 > div.mt-2 > .msg-mkdn-container > p > strong{
  display:none!important;
}

body:has(.jy-page.jy-seiran)
.ant-col-lg-18 > div.mt-2 > .msg-mkdn-container > p:has(> strong:only-child){
  margin:0!important;
  padding:0!important;
  min-height:0!important;
  line-height:0!important;
}


/* =========================================================
   PAGE / BACKGROUND
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-page{
  position:relative!important;
  z-index:2!important;

  max-width:1380px!important;
  margin:0 auto!important;
  padding-top:8px!important;
  padding-bottom:36px!important;

  color:var(--jy-text)!important;
  font-family:var(--jy-font-body)!important;
}

body:has(.jy-page.jy-seiran) .jy-bg-image{
  opacity:var(--jy-bg-opacity,.38)!important;

  object-fit:cover!important;
  object-position:center center!important;

  filter:
    saturate(1.05)
    contrast(1.02)
    brightness(.82)!important;
}

body:has(.jy-page.jy-seiran)::after{
  content:"";

  position:fixed;
  inset:0;
  z-index:0;

  pointer-events:none;

  background:
    radial-gradient(circle at 18% 8%,rgba(var(--jy-accent-2-rgb),.14),transparent 32%),
    radial-gradient(circle at 82% 20%,rgba(var(--jy-accent-rgb),.13),transparent 30%),
    linear-gradient(
      to bottom,
      rgba(17,6,18,.08) 0%,
      rgba(17,6,18,.30) 38%,
      rgba(13,5,15,.76) 100%
    );
}

body:has(.jy-page.jy-seiran) .jy-row{
  gap:22px!important;
}

body:has(.jy-page.jy-seiran) .jy-page > .jy-section,
body:has(.jy-page.jy-seiran) .jy-page > .jy-row:not(.jy-hero){
  margin-bottom:24px!important;
}


/* =========================================================
   HERO
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-hero{
  display:grid!important;
  grid-template-columns:minmax(0,1.35fr) minmax(320px,.65fr)!important;
  align-items:start!important;

  min-height:0!important;
  height:auto!important;

  margin:0 0 22px!important;
  padding:4px 0 8px!important;
}

body:has(.jy-page.jy-seiran) .jy-hero > .jy-col-7,
body:has(.jy-page.jy-seiran) .jy-hero > .jy-col-5{
  width:auto!important;
  max-width:none!important;
  min-width:0!important;
  flex:none!important;
  margin:0!important;
  padding:0!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-copy{
  align-self:flex-start!important;
  justify-content:flex-start!important;

  min-height:0!important;

  margin:0!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-panel{
  position:relative!important;

  overflow:hidden!important;

  width:100%!important;

  padding:24px 25px 24px!important;

  background:
    linear-gradient(180deg,rgba(31,10,29,.82) 0%,rgba(22,8,23,.62) 100%)!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.20)!important;
  border-radius:20px!important;

  -webkit-backdrop-filter:blur(10px)!important;
  backdrop-filter:blur(10px)!important;

  box-shadow:
    0 14px 34px rgba(0,0,0,.30),
    inset 0 1px 0 rgba(255,255,255,.035)!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-panel::before{
  content:"";

  position:absolute;
  top:0;
  left:0;
  right:0;

  height:3px;

  background:
    linear-gradient(
      90deg,
      rgba(var(--jy-accent-2-rgb),.95),
      rgba(var(--jy-accent-rgb),.98),
      rgba(var(--jy-accent-3-rgb),.90)
    );

  pointer-events:none;
}

body:has(.jy-page.jy-seiran) .jy-overline{
  display:inline-flex!important;
  align-items:center!important;
  justify-content:center!important;

  width:fit-content!important;
  max-width:100%!important;

  margin:0 0 13px!important;
  padding:7px 11px!important;

  background:rgba(255,255,255,.045)!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.20)!important;
  border-radius:999px!important;

  color:#ffd5b3!important;

  font-family:var(--jy-font-mono)!important;
  font-size:9.5px!important;
  font-weight:700!important;
  line-height:1.35!important;
  letter-spacing:.11em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-title{
  margin:0 0 8px!important;

  color:var(--jy-title)!important;

  font-family:var(--jy-font-display)!important;
  font-size:clamp(42px,5.5vw,76px)!important;
  font-weight:800!important;
  line-height:.90!important;
  letter-spacing:.025em!important;
  text-transform:uppercase!important;

  text-shadow:
    0 5px 25px rgba(0,0,0,.28),
    0 0 24px rgba(var(--jy-accent-rgb),.10)!important;
}

body:has(.jy-page.jy-seiran) .jy-subtitle{
  margin:0 0 18px!important;

  color:#ffbf95!important;

  font-family:var(--jy-font-mono)!important;
  font-size:10px!important;
  font-weight:700!important;
  line-height:1.45!important;
  letter-spacing:.11em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-blurb{
  max-width:100%!important;

  margin:0 0 13px!important;

  color:var(--jy-text-soft)!important;

  font-size:14px!important;
  line-height:1.78!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-panel .jy-blurb:last-of-type{
  margin-bottom:0!important;
}

body:has(.jy-page.jy-seiran) .jy-quote{
  margin:18px 0 0!important;
  padding:13px 15px!important;

  background:
    linear-gradient(
      90deg,
      rgba(var(--jy-accent-rgb),.10),
      rgba(var(--jy-accent-2-rgb),.045)
    )!important;

  border:1px solid rgba(var(--jy-accent-rgb),.15)!important;
  border-left:3px solid rgba(var(--jy-accent-rgb),.72)!important;
  border-radius:12px!important;

  color:#ffdce4!important;

  font-size:13.5px!important;
  line-height:1.65!important;
  font-style:italic!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-visual{
  align-self:start!important;

  display:flex!important;
  align-items:flex-start!important;
  justify-content:center!important;

  min-height:0!important;
  height:auto!important;

  margin:0!important;
  padding:0!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-sticky{
  position:static!important;
  inset:auto!important;
  top:auto!important;
  right:auto!important;
  bottom:auto!important;
  left:auto!important;

  width:100%!important;
  min-height:0!important;
  height:auto!important;
  max-height:none!important;

  display:flex!important;
  align-items:flex-start!important;
  justify-content:center!important;

  margin:0!important;
  padding:0!important;

  transform:none!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-hero-art{
  position:relative!important;

  width:100%!important;
  max-width:390px!important;

  margin:0 auto!important;
  padding:0!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-hero-stamp{
  display:flex!important;
  align-items:center!important;
  justify-content:center!important;

  width:fit-content!important;
  max-width:calc(100% - 22px)!important;

  margin:0 auto 9px!important;
  padding:6px 10px!important;

  background:rgba(24,8,22,.76)!important;
  border:1px solid rgba(var(--jy-accent-rgb),.22)!important;
  border-radius:999px!important;

  color:#ffc9d5!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8px!important;
  font-weight:700!important;
  line-height:1.3!important;
  letter-spacing:.08em!important;
  text-align:center!important;
  text-transform:uppercase!important;

  -webkit-backdrop-filter:blur(8px)!important;
  backdrop-filter:blur(8px)!important;
}

body:has(.jy-page.jy-seiran) .jy-hero-image{
  display:block!important;

  width:100%!important;
  max-width:390px!important;
  height:auto!important;
  max-height:none!important;

  margin:0 auto!important;

  object-fit:contain!important;

  border:0!important;
  border-radius:18px!important;

  background:transparent!important;

  box-shadow:
    0 18px 38px rgba(0,0,0,.38),
    0 0 32px rgba(var(--jy-accent-rgb),.10)!important;
}


/* =========================================================
   GENERIC SECTION SHELL
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-section{
  position:relative!important;
  overflow:hidden!important;

  background:
    linear-gradient(
      180deg,
      rgba(31,11,29,.93) 0%,
      rgba(19,8,21,.91) 100%
    )!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.16)!important;
  border-radius:var(--jy-radius)!important;

  -webkit-backdrop-filter:blur(9px)!important;
  backdrop-filter:blur(9px)!important;

  box-shadow:var(--jy-shadow)!important;
}

body:has(.jy-page.jy-seiran) .jy-section::before{
  content:"";

  position:absolute;
  top:0;
  left:0;
  right:0;

  height:2px;

  background:
    linear-gradient(
      90deg,
      rgba(var(--jy-accent-2-rgb),.84),
      rgba(var(--jy-accent-rgb),.93),
      rgba(var(--jy-accent-3-rgb),.72)
    );

  pointer-events:none;
}

body:has(.jy-page.jy-seiran) .jy-section-title{
  padding:14px 18px 12px!important;

  border-bottom:1px solid rgba(255,255,255,.055)!important;

  color:#fff0f3!important;

  font-family:var(--jy-font-mono)!important;
  font-size:10.5px!important;
  font-weight:700!important;
  line-height:1.45!important;
  letter-spacing:.16em!important;
  text-align:center!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-section-body{
  padding:21px!important;

  color:var(--jy-text-soft)!important;

  font-size:14px!important;
  line-height:1.78!important;
}

body:has(.jy-page.jy-seiran) .jy-section-body p{
  margin:0 0 14px!important;
}

body:has(.jy-page.jy-seiran) .jy-section-body p:last-child{
  margin-bottom:0!important;
}

body:has(.jy-page.jy-seiran) strong{
  color:#fff0dc!important;
}


/* =========================================================
   ORIENTATION VIDEO
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-seiran-video-frame{
  position:relative!important;

  overflow:hidden!important;

  width:100%!important;
  max-width:1120px!important;

  margin-left:auto!important;
  margin-right:auto!important;

  background:#09060c!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.24)!important;
  border-radius:17px!important;

  box-shadow:
    0 14px 34px rgba(0,0,0,.36),
    0 0 26px rgba(var(--jy-accent-rgb),.08)!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-frame::after{
  content:"";

  position:absolute;
  inset:0;

  border-radius:inherit;

  box-shadow:
    inset 0 0 0 1px rgba(255,255,255,.018);

  pointer-events:none;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-badge{
  position:absolute!important;
  top:12px!important;
  left:12px!important;
  z-index:3!important;

  padding:6px 10px!important;

  background:rgba(20,7,18,.80)!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.27)!important;
  border-radius:999px!important;

  color:#ffd8bd!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8.5px!important;
  font-weight:700!important;
  line-height:1.2!important;
  letter-spacing:.09em!important;
  text-transform:uppercase!important;

  -webkit-backdrop-filter:blur(8px)!important;
  backdrop-filter:blur(8px)!important;

  pointer-events:none!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video{
  display:block!important;

  width:100%!important;
  height:auto!important;

  max-height:720px!important;

  margin:0!important;

  background:#000!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-footer{
  padding:15px 6px 2px!important;

  text-align:center!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-status{
  display:inline-flex!important;
  align-items:center!important;
  justify-content:center!important;

  width:fit-content!important;

  margin:0 auto 10px!important;
  padding:6px 11px!important;

  background:rgba(var(--jy-accent-rgb),.085)!important;

  border:1px solid rgba(var(--jy-accent-rgb),.21)!important;
  border-radius:999px!important;

  color:#ffbfd0!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8.5px!important;
  font-weight:700!important;
  line-height:1.2!important;
  letter-spacing:.09em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-caption{
  max-width:760px!important;

  margin:0 auto!important;

  color:var(--jy-text-muted)!important;

  font-size:12.5px!important;
  line-height:1.68!important;
  text-align:center!important;
}


/* =========================================================
   GUILLOTINE / RESTRICTED ENFORCEMENT VIDEO
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-section{
  border-color:rgba(var(--jy-danger-rgb),.26)!important;

  background:
    linear-gradient(
      180deg,
      rgba(35,8,17,.95) 0%,
      rgba(17,6,13,.94) 100%
    )!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-section::before{
  background:
    linear-gradient(
      90deg,
      rgba(var(--jy-danger-rgb),.95),
      rgba(var(--jy-accent-rgb),.65),
      rgba(var(--jy-danger-rgb),.95)
    )!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-section .jy-section-title{
  color:#ffd8dd!important;

  border-bottom-color:rgba(var(--jy-danger-rgb),.16)!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-warning-row{
  display:flex!important;
  flex-wrap:wrap!important;
  justify-content:center!important;
  gap:8px!important;

  margin:0 0 15px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-danger-badge{
  display:inline-flex!important;
  align-items:center!important;
  justify-content:center!important;

  padding:6px 10px!important;

  background:rgba(var(--jy-danger-rgb),.09)!important;

  border:1px solid rgba(var(--jy-danger-rgb),.24)!important;
  border-radius:999px!important;

  color:#ffb8c2!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8.5px!important;
  font-weight:700!important;
  line-height:1.2!important;
  letter-spacing:.09em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-danger{
  border-color:rgba(var(--jy-danger-rgb),.34)!important;

  box-shadow:
    0 14px 34px rgba(0,0,0,.42),
    0 0 28px rgba(var(--jy-danger-rgb),.09)!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-video-danger .jy-seiran-video-badge{
  background:rgba(34,5,12,.84)!important;

  border-color:rgba(var(--jy-danger-rgb),.30)!important;

  color:#ffc4cc!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-copy{
  margin-top:17px!important;
  padding:17px 18px!important;

  background:
    linear-gradient(
      180deg,
      rgba(var(--jy-danger-rgb),.055),
      rgba(255,255,255,.018)
    )!important;

  border:1px solid rgba(var(--jy-danger-rgb),.15)!important;
  border-left:3px solid rgba(var(--jy-danger-rgb),.62)!important;
  border-radius:13px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-copy h3{
  margin:0 0 10px!important;

  color:#ffe4e8!important;

  font-size:17px!important;
  font-weight:800!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-copy p{
  margin:0 0 11px!important;

  color:#ddbfc6!important;

  font-size:13px!important;
  line-height:1.72!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-guillotine-copy p:last-child{
  margin-bottom:0!important;
}


/* =========================================================
   POWER BLOC CARDS
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-mini-card{
  position:relative!important;

  height:100%!important;

  padding:20px 18px!important;

  overflow:hidden!important;

  background:
    linear-gradient(
      180deg,
      rgba(33,12,30,.90),
      rgba(21,8,22,.89)
    )!important;

  border:1px solid rgba(255,255,255,.065)!important;
  border-radius:16px!important;

  -webkit-backdrop-filter:blur(8px)!important;
  backdrop-filter:blur(8px)!important;

  box-shadow:0 10px 28px rgba(0,0,0,.27)!important;

  transition:
    transform .20s ease,
    border-color .20s ease,
    box-shadow .20s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-mini-card::before{
  content:"";

  position:absolute;
  top:0;
  left:0;
  right:0;

  height:2px;

  background:var(--jy-accent)!important;

  opacity:.85;
}

body:has(.jy-page.jy-seiran) .jy-row > .jy-col-4:nth-child(1) .jy-mini-card::before{
  background:#ffb060!important;
}

body:has(.jy-page.jy-seiran) .jy-row > .jy-col-4:nth-child(2) .jy-mini-card::before{
  background:#ff5b83!important;
}

body:has(.jy-page.jy-seiran) .jy-row > .jy-col-4:nth-child(3) .jy-mini-card::before{
  background:#ffd28e!important;
}

body:has(.jy-page.jy-seiran) .jy-mini-card:hover{
  transform:translateY(-3px)!important;

  border-color:rgba(var(--jy-accent-rgb),.20)!important;

  box-shadow:0 14px 32px rgba(0,0,0,.32)!important;
}

body:has(.jy-page.jy-seiran) .jy-mini-title{
  margin:0 0 9px!important;

  color:#fff1dd!important;

  font-family:var(--jy-font-mono)!important;
  font-size:10px!important;
  font-weight:700!important;
  line-height:1.25!important;
  letter-spacing:.13em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-mini-card p{
  margin:0!important;

  color:var(--jy-text-soft)!important;

  font-size:12.5px!important;
  line-height:1.68!important;
}


/* =========================================================
   SCENARIO ARCHIVE — VERTICAL SCROLL
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-archive-list{
  display:flex!important;
  flex-direction:column!important;
  gap:14px!important;

  max-height:760px!important;

  overflow-y:auto!important;
  overflow-x:hidden!important;

  padding:3px 9px 3px 2px!important;

  scrollbar-width:thin;
  scrollbar-color:var(--jy-accent) rgba(255,255,255,.04);
}

body:has(.jy-page.jy-seiran) .jy-archive-list::-webkit-scrollbar{
  width:7px!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-list::-webkit-scrollbar-track{
  background:rgba(255,255,255,.035)!important;

  border-radius:999px!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-list::-webkit-scrollbar-thumb{
  background:
    linear-gradient(
      180deg,
      var(--jy-accent-2),
      var(--jy-accent)
    )!important;

  border-radius:999px!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-card{
  display:grid!important;
  grid-template-columns:220px minmax(0,1fr)!important;
  gap:17px!important;
  align-items:center!important;

  min-width:0!important;

  padding:14px!important;

  background:
    linear-gradient(
      180deg,
      rgba(255,255,255,.035),
      rgba(255,255,255,.020)
    )!important;

  border:1px solid rgba(255,255,255,.065)!important;
  border-radius:15px!important;

  transition:
    transform .20s ease,
    background .20s ease,
    border-color .20s ease,
    box-shadow .20s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-card:hover{
  transform:translateY(-2px)!important;

  background:rgba(var(--jy-accent-rgb),.045)!important;

  border-color:rgba(var(--jy-accent-rgb),.22)!important;

  box-shadow:0 9px 22px rgba(0,0,0,.23)!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-img{
  display:block!important;

  width:220px!important;
  height:145px!important;

  margin:0!important;

  object-fit:cover!important;
  object-position:center 18%!important;

  border:1px solid rgba(255,255,255,.075)!important;
  border-radius:11px!important;

  background:#0a0710!important;

  image-rendering:auto!important;
  filter:none!important;
  transform:none!important;

  transition:object-position 1.45s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-card:hover .jy-archive-img,
body:has(.jy-page.jy-seiran) .jy-archive-card:focus-within .jy-archive-img{
  object-position:center 36%!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-content{
  min-width:0!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-meta{
  display:flex!important;
  flex-wrap:wrap!important;
  align-items:center!important;
  gap:8px!important;

  margin:0 0 8px!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-case,
body:has(.jy-page.jy-seiran) .jy-archive-tagline{
  display:inline-flex!important;
  align-items:center!important;
  justify-content:center!important;

  padding:5px 9px!important;

  border-radius:999px!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8.5px!important;
  font-weight:700!important;
  line-height:1.1!important;
  letter-spacing:.07em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-case{
  background:rgba(var(--jy-accent-2-rgb),.095)!important;

  border:1px solid rgba(var(--jy-accent-2-rgb),.18)!important;

  color:#ffd8b7!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-tagline{
  background:rgba(var(--jy-accent-rgb),.09)!important;

  border:1px solid rgba(var(--jy-accent-rgb),.17)!important;

  color:#ffc2d0!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-card h4{
  margin:0 0 7px!important;

  color:#fff4f5!important;

  font-size:17px!important;
  font-weight:800!important;
  line-height:1.2!important;
  letter-spacing:.01em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-archive-card p{
  margin:0!important;

  color:var(--jy-text-soft)!important;

  font-size:13.2px!important;
  line-height:1.68!important;
}




/* =========================================================
   ISLAND DOSSIER — HORIZONTAL PERSONNEL GALLERY
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-seiran-gallery-intro{
  max-width:780px!important;

  margin:0 auto 16px!important;

  color:var(--jy-text-muted)!important;

  font-size:12.7px!important;
  line-height:1.68!important;
  text-align:center!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-gallery-scroll{
  display:flex!important;
  align-items:stretch!important;
  gap:15px!important;

  width:100%!important;
  max-width:100%!important;

  overflow-x:auto!important;
  overflow-y:hidden!important;

  padding:4px 2px 15px!important;

  scroll-snap-type:x proximity;
  scrollbar-width:thin;
  scrollbar-color:var(--jy-accent) rgba(255,255,255,.04);
  -webkit-overflow-scrolling:touch;
}

body:has(.jy-page.jy-seiran) .jy-seiran-gallery-scroll::-webkit-scrollbar{
  height:7px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-gallery-scroll::-webkit-scrollbar-track{
  background:rgba(255,255,255,.035)!important;
  border-radius:999px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-gallery-scroll::-webkit-scrollbar-thumb{
  background:
    linear-gradient(
      90deg,
      var(--jy-accent-2),
      var(--jy-accent)
    )!important;

  border-radius:999px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel{
  flex:0 0 238px!important;

  width:238px!important;
  min-width:238px!important;
  max-width:238px!important;

  overflow:hidden!important;

  scroll-snap-align:start!important;

  background:
    linear-gradient(
      180deg,
      rgba(39,13,34,.97),
      rgba(20,8,22,.97)
    )!important;

  border:1px solid rgba(255,255,255,.075)!important;
  border-radius:15px!important;

  box-shadow:0 8px 22px rgba(0,0,0,.27)!important;

  transition:
    transform .20s ease,
    border-color .20s ease,
    box-shadow .20s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel:hover{
  transform:translateY(-3px)!important;

  border-color:rgba(var(--jy-accent-rgb),.24)!important;

  box-shadow:0 12px 28px rgba(0,0,0,.33)!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel-img{
  display:block!important;

  width:238px!important;
  height:292px!important;

  margin:0!important;
  padding:0!important;

  object-fit:cover!important;
  object-position:center 14%!important;

  border:0!important;
  border-radius:0!important;

  background:#0c0710!important;

  image-rendering:auto!important;
  filter:none!important;
  transform:none!important;

  transition:object-position 1.55s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel:hover .jy-seiran-personnel-img,
body:has(.jy-page.jy-seiran) .jy-seiran-personnel:focus-within .jy-seiran-personnel-img{
  object-position:center 34%!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel-body{
  padding:12px 13px 14px!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel-code{
  display:block!important;

  margin:0 0 5px!important;

  color:#ffb47b!important;

  font-family:var(--jy-font-mono)!important;
  font-size:8px!important;
  font-weight:700!important;
  line-height:1.25!important;
  letter-spacing:.09em!important;
  text-transform:uppercase!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel-name{
  margin:0 0 6px!important;

  color:#fff1f3!important;

  font-size:14px!important;
  font-weight:800!important;
  line-height:1.25!important;
}

body:has(.jy-page.jy-seiran) .jy-seiran-personnel-role{
  margin:0!important;

  color:var(--jy-text-muted)!important;

  font-size:11.7px!important;
  line-height:1.55!important;
}


/* =========================================================
   CREATOR BUTTONS
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-btn-row{
  display:flex!important;
  flex-wrap:wrap!important;
  justify-content:center!important;
  gap:9px!important;
}

body:has(.jy-page.jy-seiran) .jy-btn{
  display:inline-flex!important;
  align-items:center!important;
  justify-content:center!important;

  min-height:36px!important;

  padding:8px 13px!important;

  background:
    linear-gradient(
      135deg,
      rgba(var(--jy-accent-rgb),.92),
      rgba(190,46,90,.96)
    )!important;

  border:1px solid rgba(255,255,255,.08)!important;
  border-radius:10px!important;

  color:#fff!important;

  font-family:var(--jy-font-body)!important;
  font-size:11.5px!important;
  font-weight:700!important;
  text-decoration:none!important;

  box-shadow:none!important;

  transition:
    transform .18s ease,
    box-shadow .18s ease,
    filter .18s ease!important;
}

body:has(.jy-page.jy-seiran) .jy-btn:hover{
  transform:translateY(-2px)!important;

  filter:brightness(1.05)!important;

  box-shadow:0 8px 18px rgba(0,0,0,.24)!important;
}


/* =========================================================
   OPTIONAL FLOATING CHIBI
   Ready for later if HTML uses .jy-seiran-chibi
   ========================================================= */

body:has(.jy-page.jy-seiran) .jy-seiran-chibi{
  position:fixed!important;
  right:20px!important;
  bottom:84px!important;
  z-index:9999!important;

  display:block!important;

  width:78px!important;
  height:auto!important;
  max-width:none!important;

  margin:0!important;
  padding:0!important;

  border:0!important;
  background:transparent!important;
  box-shadow:none!important;

  object-fit:contain!important;

  filter:
    drop-shadow(0 8px 11px rgba(0,0,0,.45))
    drop-shadow(0 0 9px rgba(var(--jy-accent-rgb),.12))!important;

  pointer-events:none!important;
}


/* =========================================================
   TABLET
   ========================================================= */

@media(max-width:1000px){

  body:has(.jy-page.jy-seiran) .jy-hero{
    grid-template-columns:minmax(0,1.2fr) minmax(285px,.8fr)!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-hero-art,
  body:has(.jy-page.jy-seiran) .jy-hero-image{
    max-width:350px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-card{
    grid-template-columns:190px minmax(0,1fr)!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-img{
    width:190px!important;
    height:132px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero-image{
    max-width:390px!important;
  }

}


/* =========================================================
   MOBILE
   ========================================================= */

@media(max-width:768px){

  body:has(.jy-page.jy-seiran) .jy-page{
    width:100%!important;
    max-width:100%!important;

    margin:0 auto!important;

    padding-top:2px!important;
    padding-left:0!important;
    padding-right:0!important;
    padding-bottom:112px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-row{
    width:100%!important;

    margin-left:auto!important;
    margin-right:auto!important;

    gap:16px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero{
    display:grid!important;
    grid-template-columns:1fr!important;

    align-items:start!important;
    justify-content:stretch!important;

    width:100%!important;

    margin:0 auto 18px!important;
    padding:0!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero-copy{
    width:100%!important;
    max-width:100%!important;

    margin:0 auto!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero-panel{
    width:calc(100% - 24px)!important;

    margin:0 auto!important;
    padding:18px 16px 20px!important;

    border-radius:18px!important;

    text-align:left!important;
  }

  body:has(.jy-page.jy-seiran) .jy-overline{
    display:flex!important;

    width:100%!important;

    margin:0 auto 14px!important;

    justify-content:center!important;

    text-align:center!important;

    font-size:8.5px!important;
    letter-spacing:.075em!important;
  }

  body:has(.jy-page.jy-seiran) .jy-title{
    width:100%!important;
    max-width:100%!important;

    margin:0 auto 8px!important;

    font-size:clamp(38px,12vw,56px)!important;
    line-height:.92!important;
    letter-spacing:.01em!important;

    text-align:center!important;

    white-space:normal!important;
  }

  body:has(.jy-page.jy-seiran) .jy-subtitle{
    width:100%!important;

    margin:0 auto 17px!important;

    font-size:8.5px!important;
    line-height:1.45!important;
    letter-spacing:.075em!important;

    text-align:center!important;
  }

  body:has(.jy-page.jy-seiran) .jy-blurb{
    font-size:13.4px!important;
    line-height:1.72!important;

    text-align:left!important;
  }

  body:has(.jy-page.jy-seiran) .jy-quote{
    font-size:12.5px!important;
    line-height:1.65!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero-visual,
  body:has(.jy-page.jy-seiran) .jy-hero-sticky{
    width:100%!important;

    margin:0 auto!important;

    display:flex!important;
    align-items:flex-start!important;
    justify-content:center!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-hero-art{
    width:calc(100% - 24px)!important;
    max-width:390px!important;

    margin:0 auto!important;
  }

  body:has(.jy-page.jy-seiran) .jy-hero-image{
    width:100%!important;
    max-width:390px!important;

    margin:0 auto!important;

    border-radius:18px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-section{
    width:calc(100% - 24px)!important;
    max-width:100%!important;

    margin-left:auto!important;
    margin-right:auto!important;

    border-radius:17px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-section-title{
    padding:13px 12px 11px!important;

    font-size:9.2px!important;
    line-height:1.45!important;
    letter-spacing:.11em!important;
  }

  body:has(.jy-page.jy-seiran) .jy-section-body{
    padding:16px!important;

    font-size:13px!important;
    line-height:1.72!important;
  }

  body:has(.jy-page.jy-seiran) .jy-mini-card{
    width:calc(100% - 24px)!important;

    margin-left:auto!important;
    margin-right:auto!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-video-badge{
    top:9px!important;
    left:9px!important;

    max-width:calc(100% - 18px)!important;

    padding:5px 8px!important;

    font-size:7.4px!important;
    letter-spacing:.055em!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-video-caption{
    font-size:11.8px!important;
    line-height:1.62!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-warning-row{
    gap:6px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-danger-badge{
    font-size:7.6px!important;
    letter-spacing:.055em!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-list{
    max-height:650px!important;

    padding-right:6px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-card{
    grid-template-columns:1fr!important;

    gap:12px!important;

    padding:13px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-img{
    width:100%!important;
    height:auto!important;

    aspect-ratio:16 / 10!important;

    object-position:center 16%!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-card:hover .jy-archive-img,
  body:has(.jy-page.jy-seiran) .jy-archive-card:focus-within .jy-archive-img{
    object-position:center 30%!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-card h4{
    font-size:15.5px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-archive-card p{
    font-size:12.4px!important;
    line-height:1.62!important;
  }


  body:has(.jy-page.jy-seiran) .jy-seiran-gallery-intro{
    font-size:12px!important;
    line-height:1.62!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-personnel{
    flex-basis:212px!important;

    width:212px!important;
    min-width:212px!important;
    max-width:212px!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-personnel-img{
    width:212px!important;
    height:260px!important;

    object-position:center 12%!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-personnel:hover .jy-seiran-personnel-img,
  body:has(.jy-page.jy-seiran) .jy-seiran-personnel:focus-within .jy-seiran-personnel-img{
    object-position:center 28%!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-chibi{
    right:7px!important;
    bottom:88px!important;

    width:58px!important;
  }

}


/* =========================================================
   SMALL MOBILE
   ========================================================= */

@media(max-width:480px){

  body:has(.jy-page.jy-seiran) .jy-hero-panel,
  body:has(.jy-page.jy-seiran) .jy-section,
  body:has(.jy-page.jy-seiran) .jy-mini-card{
    width:calc(100% - 16px)!important;
  }

  body:has(.jy-page.jy-seiran) .jy-title{
    font-size:clamp(34px,11.5vw,48px)!important;
  }

}


/* =========================================================
   TOUCH DEVICES — SUBTLE AUTOMATIC SCENARIO PAN
   ========================================================= */

@keyframes jySeiranScenarioPan{
  from{object-position:center 14%}
  to{object-position:center 30%}
}

@keyframes jySeiranPersonnelPan{
  from{object-position:center 10%}
  to{object-position:center 28%}
}

@media(hover:none) and (pointer:coarse){

  body:has(.jy-page.jy-seiran) .jy-archive-img{
    animation:jySeiranScenarioPan 8s ease-in-out infinite alternate!important;
  }

  body:has(.jy-page.jy-seiran) .jy-seiran-personnel-img{
    animation:jySeiranPersonnelPan 10s ease-in-out infinite alternate!important;
  }

}


/* =========================================================
   REDUCED MOTION
   ========================================================= */

@media(prefers-reduced-motion:reduce){

  body:has(.jy-page.jy-seiran) .jy-mini-card,
  body:has(.jy-page.jy-seiran) .jy-archive-card,
  body:has(.jy-page.jy-seiran) .jy-archive-img,
  body:has(.jy-page.jy-seiran) .jy-seiran-personnel,
  body:has(.jy-page.jy-seiran) .jy-seiran-personnel-img,
  body:has(.jy-page.jy-seiran) .jy-btn{
    transition:none!important;
    animation:none!important;
  }

  body:has(.jy-page.jy-seiran) .jy-mini-card:hover,
  body:has(.jy-page.jy-seiran) .jy-archive-card:hover,
  body:has(.jy-page.jy-seiran) .jy-btn:hover{
    transform:none!important;
  }

}
