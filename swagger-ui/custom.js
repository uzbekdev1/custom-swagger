(function () {
    window.addEventListener("load", function () {
        setTimeout(function () {
            var links = document.querySelectorAll("link[rel~='icon']");

            for (var link of links) {
                link.remove();
            }

            var link = document.createElement('link');
            link.rel = 'icon';
            document.head.appendChild(link);
            link.href = 'icon.png';
        });
    });
})();