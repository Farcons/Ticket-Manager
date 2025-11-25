window.ticketManager = {
    downloadFile: function (filename, content) {
        const blob = new Blob([content], { type: 'text/csv;charset=utf-8;' });
        const link = document.createElement('a');
        link.href = URL.createObjectURL(blob);
        link.download = filename;
        document.body.appendChild(link);
        link.click();
        link.remove();
    },

    registerShortcuts: function () {
        document.addEventListener('keydown', function (e) {
            // Ctrl+N -> abrir /cadastro
            if (e.ctrlKey && e.key === 'n') {
                e.preventDefault();
                window.location.href = '/cadastro';
            }
            // Ctrl+Shift+R -> abrir relatorio (opcional)
            if (e.ctrlKey && e.shiftKey && e.key.toLowerCase() === 'r') {
                e.preventDefault();
                window.location.href = '/relatorio';
            }
        });
    },

    // usado na página de edição/cadastro para salvar via ctrl+enter
    registerSaveShortcut: function (dotNetRef) {
        document.addEventListener('keydown', function (e) {
            if ((e.ctrlKey || e.metaKey) && e.key === 'Enter') {
                e.preventDefault();
                dotNetRef.invokeMethodAsync('OnShortcutSave');
            }
        });
    }
};
