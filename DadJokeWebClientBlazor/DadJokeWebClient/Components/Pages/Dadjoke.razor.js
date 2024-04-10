window.copyClipboard = (dadJoke) => {
    var copyText = 'git commit -m "' + dadJoke + '"';
    if (navigator.clipboard){
        navigator.clipboard.writeText(copyText)
        alert("Copied the text: " + copyText);
    }else{
        alert("Untrusted sites don't have access to copy text to your clipboard\nThe copied the text would have been: " + copyText)
    }
}