@media only screen and (max-width: 1024px) {
  body .projects {
    padding: 0 1rem; }
    body .projects__project {
      width: 225px; } }
@media only screen and (max-width: 900px) {
  body .intro {
    height: auto;
    display: flex;
    flex-direction: column;
    justify-content: start;
    align-items: center;
    padding: 1.5em 0; }
    body .intro > * {
      width: 90%;
      margin: 0; }
    body .intro__img img {
      width: 125px;
      height: 125px; }
    body .intro__text {
      text-align: center; }
    body .intro__social {
      width: auto;
      height: 45px;
      display: flex;
      justify-content: center;
      align-items: center; }
  body .scroll-down {
    width: 75px;
    height: 75px; }
  body .bio__text {
    width: 80%; }
  body .bio__icon {
    width: 50px;
    height: 50px;
    margin-top: calc(-25px - 1rem); }
  body .experience__current {
    width: 80%; }
  body .experience__list {
    width: 80%; }
  body .projects {
    padding: 0 1rem; }
    body .projects__container {
      margin: .5rem 0 1rem 0; }
    body .projects__project {
      width: 200px;
      margin: 0 1.25rem; }
      body .projects__project .icon {
        width: 50px;
        height: 50px; }
      body .projects__project .name {
        height: 35px;
        font-size: 1rem;
        font-weight: bold;
        line-height: 35px; }
      body .projects__project .desc {
        height: 135px;
        overflow: hidden; }
  body .skills__container {
    width: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center; }
  body .skills__side {
    width: 75%; }
  body .skills__list {
    width: 100%; }
  body .interests {
    width: 100%;
    padding: 0 1rem; }
    body .interests__interest {
      margin: 0 1.25rem; } }
@media only screen and (max-width: 768px) {
  body hr {
    margin: 15px auto; }
  body .bio__text {
    width: 90%; }
  body .bio__icon {
    width: 50px;
    height: 50px;
    margin-top: calc(-25px - 1rem); }
  body .experience__current {
    width: 90%; }
  body .experience__list {
    width: 90%; }
  body .projects {
    padding: 0 1rem; }
    body .projects__container {
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      margin: .5rem 0 1rem 0; }
    body .projects__project {
      width: 90%;
      height: 125px;
      padding: 10px;
      margin: .75rem auto;
      position: relative;
      text-align: left; }
      body .projects__project > * {
        display: inline;
        position: absolute;
        padding: .25rem;
        border-radius: 5px; }
      body .projects__project .icon {
        width: 115px;
        height: 115px;
        top: 5px;
        left: 5px;
        padding: 1rem; }
      body .projects__project .name {
        height: 45px;
        font-size: 1rem;
        font-weight: bold;
        top: 5px;
        left: 120px; }
      body .projects__project .desc {
        padding-right: 1.25rem;
        height: 70px;
        overflow: hidden;
        font-size: .9rem;
        top: 50px;
        left: 120px; }
  body .skills__side {
    width: 85%; }
  body .interests {
    padding: 0 1rem; }
    body .interests__container {
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      margin: .5rem 0 1rem 0; }
    body .interests__interest {
      width: 75%;
      height: 75px;
      margin: .75rem auto;
      text-align: center;
      display: flex;
      justify-content: center;
      align-items: center; }
      body .interests__interest > * {
        height: 65px;
        margin: 0 1rem; }
      body .interests__interest .icon {
        margin: 0;
        width: 65px; }
      body .interests__interest .name {
        width: 125px;
        font-size: 1rem;
        font-weight: bold;
        line-height: auto; } }
* {
  outline: none;
  box-sizing: border-box;
  text-decoration: none;
  font-family: 'DM Serif Display', serif;
  transition-duration: 0.25s;
  background-color: #fff;
  color: #000; }

html {
  font-size: 100%; }

body {
  margin: 0;
  padding: 0; }

.section {
  width: 100%;
  max-width: 1440px;
  margin: 1rem auto; }

hr {
  width: 50%;
  border: .5px solid #bbb;
  margin: 25px auto;
  text-align: center; }

.intro {
  height: 25rem;
  margin-top: 0;
  display: flex;
  justify-content: space-around;
  align-items: center; }
  .intro > * {
    width: 50%;
    text-align: center; }
  .intro__img {
    margin-left: 2em; }
    .intro__img img {
      width: 225px;
      height: 225px;
      border-radius: 50%; }
  .intro__text {
    text-align: left;
    margin-right: 2em; }
    .intro__text > * {
      width: 50%;
      margin: 15px auto; }
  .intro__social {
    width: 50%;
    height: 45px;
    display: flex;
    justify-content: start;
    align-items: center; }
    .intro__social > * {
      width: 45px;
      min-width: 45px;
      height: 45px;
      box-shadow: -4px 4px 0px #000;
      border-radius: 3px;
      margin: 7.5px;
      border: 1px solid #000;
      display: flex;
      justify-content: center;
      align-items: center; }
      .intro__social > * img {
        width: 30px;
        height: 30px; }

.scroll-down {
  width: 100px;
  height: 100px;
  margin: 0 auto;
  text-align: center; }

.bio__text {
  width: 65%;
  padding: 1.5rem;
  box-shadow: -7.5px 7.5px 0px #000;
  border-radius: 3px;
  border: 1px solid #000;
  margin: 0 auto 1rem auto; }
.bio__icon {
  width: 75px;
  height: 75px;
  margin: 0 auto;
  margin-top: calc(-36px - 1rem);
  border-radius: 50%; }
  .bio__icon img {
    width: 100%;
    border-radius: 50%; }

.experience {
  text-align: center;
  padding-bottom: .5rem; }
  .experience > * {
    margin: 1rem auto; }
  .experience h1 {
    margin: 0 auto; }
  .experience__current {
    width: 65%;
    min-height: 150px;
    padding: .75rem;
    border: 1px solid #000;
    box-shadow: -7.5px 7.5px 0px #000;
    border-radius: 3px; }
    .experience__current > * {
      width: 90%;
      margin: .5rem auto; }
    .experience__current__link {
      width: 150px;
      height: 40px;
      line-height: 40px;
      display: block;
      margin-top: 1rem;
      border: 1px solid #000;
      border-radius: 3px; }
      .experience__current__link--inexistent {
        display: none; }
  .experience__list {
    width: 65%;
    padding: .5rem 0;
    margin: 1.5rem auto 0 auto; }
    .experience__list__items {
      display: flex;
      align-items: center;
      justify-content: space-around; }
    .experience__list__item {
      width: 20px;
      height: 20px;
      cursor: pointer;
      margin: 0 .5rem;
      border-radius: 50%;
      border: 1px solid #000;
      display: flex;
      align-items: center;
      justify-content: center;
      z-index: 1; }
      .experience__list__item span {
        width: 50%;
        height: 50%;
        border: none;
        border-radius: 50%;
        display: block; }
      .experience__list__item--active span {
        background-color: #000; }
    .experience__list hr {
      width: 100%;
      border: 1px solid #000;
      border-radius: 1px;
      margin: 0 auto;
      position: relative;
      top: -12px;
      z-index: 0; }

.projects {
  width: 100%;
  padding: 0 2rem;
  text-align: center; }
  .projects__container {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 1rem 0 2rem 0; }
  .projects__project {
    width: 250px;
    padding: 1rem;
    box-shadow: -7.5px 7.5px 0px #000;
    border-radius: 3px;
    border: 1px solid #000;
    margin: 0 1em; }
    .projects__project .icon {
      width: 75px;
      height: 75px;
      margin: 0 auto; }
    .projects__project .name {
      height: 50px;
      font-size: 1.5rem;
      font-weight: bold;
      line-height: 50px; }
    .projects__project .desc {
      height: 150px;
      overflow: hidden; }
  .projects__more {
    width: 150px;
    height: 50px;
    cursor: pointer;
    box-shadow: -4px 4px 0px #000;
    border-radius: 3px;
    border: 1px solid #000;
    line-height: 47.5px;
    margin: 1.5rem auto; }

.skills {
  text-align: center;
  padding: 0 2rem; }
  .skills h1 {
    margin: 0; }
  .skills__container {
    width: 100%;
    text-align: left;
    display: flex;
    justify-content: center;
    align-items: center; }
  .skills__side {
    width: 325px;
    margin: 0 3rem; }
  .skills__list {
    width: 325px;
    padding: 1rem;
    box-shadow: -7.5px 7.5px 0px #000;
    border-radius: 3px;
    border: 1px solid #000; }
    .skills__list li {
      list-style-type: square; }
  .skills__icon {
    width: 50px;
    height: 50px;
    border-radius: 50%;
    background-color: #000;
    padding: .75rem;
    margin: -25px 0 0 -25px; }
    .skills__icon > * {
      background-color: #000; }

.interests {
  width: 100%;
  padding: 0 2rem;
  text-align: center; }
  .interests__container {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 1rem 0 2rem 0; }
  .interests__interest {
    width: 175px;
    height: 225px;
    padding: .75rem;
    box-shadow: -7.5px 7.5px 0px #000;
    border-radius: 3px;
    border: 1px solid #000;
    margin: 0 2rem; }
    .interests__interest > * {
      height: 100px; }
    .interests__interest .icon {
      width: 75px;
      padding: .5rem;
      margin: 0 auto; }
    .interests__interest .name {
      font-size: 1.25rem;
      font-weight: bold;
      display: flex;
      justify-content: center;
      align-items: center; }
  .interests__more {
    max-width: 200px;
    height: 50px;
    line-height: 47.5px;
    margin: 1.5rem auto; }

.contact {
  width: 100%;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center; }
  .contact__btn {
    width: 150px;
    height: 50px;
    cursor: pointer;
    box-shadow: -4px 4px 0px #000;
    border-radius: 3px;
    border: 1px solid #000;
    font-weight: bold;
    line-height: 47.5px;
    margin: 1rem auto; }

.footer {
  height: 100px;
  font-size: .75rem;
  margin: 0 auto;
  padding: 0 1rem;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center;
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
  background-color: #000; }
  .footer__text {
    color: #fff;
    background-color: transparent; }
  .footer a {
    width: 75px;
    height: 75px;
    display: block; }

/*# sourceMappingURL=style.cs.map */
