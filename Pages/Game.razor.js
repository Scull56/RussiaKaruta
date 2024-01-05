export function InitAudioPlay(audioElement) {

    if (audioElement) {
        audioElement.addEventListener("canplaythrough", (e) => {
            audioElement.play();
        })
    }
    
}