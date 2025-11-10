// wwwroot/js/cornerFold.js
window.initCornerFoldAnimation = (cardRef) => {
    if (!cardRef) return;

    // The 'corner-fold' element is the piece we'll rotate in 3D.
    const foldEl = cardRef.querySelector('.corner-fold');
    if (!foldEl) return;

    // Check if popmotion is loaded
    if (!window.popmotion || !window.popmotion.animate) {
        console.warn('Popmotion library not loaded yet, skipping corner fold animation');
        return;
    }

    const { animate } = window.popmotion;  // from popmotion.global.min.js
    let currentAnimation = null;

    function foldUp() {
        if (currentAnimation) currentAnimation.stop();
        currentAnimation = animate({
            from: { rotateX: 0 },
            to:   { rotateX: -90 },
            duration: 300,
            onUpdate: (latest) => {
                foldEl.style.transform = `rotateX(${latest.rotateX}deg)`;
            }
        });
    }

    function foldDown() {
        if (currentAnimation) currentAnimation.stop();
        currentAnimation = animate({
            from: { rotateX: -90 },
            to:   { rotateX: 0 },
            duration: 300,
            onUpdate: (latest) => {
                foldEl.style.transform = `rotateX(${latest.rotateX}deg)`;
            }
        });
    }

    // Attach pointerenter/pointerleave to the entire card
    // so that when you hover over or leave the card, it folds/unfolds.
    cardRef.addEventListener('pointerenter', foldUp);
    cardRef.addEventListener('pointerleave', foldDown);
};