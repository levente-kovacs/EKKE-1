const toTopBtn = document.querySelector('.to-top');

toTopBtn.addEventListener('click', () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
});
