export const delNullNodes = (option = {}) => {
    Object.keys(option).forEach((key) => {
        let value = option[key];
        value && typeof value === 'object' && delNullNodes(value);
        (value === null || value === undefined) && delete option[key];
    })
}

export function initVditor(element, dotNet, options) {
    if (window.load_vditor === undefined) {
        window.load_vditor = 1;
        setTimeout(createVditor, 100, element, dotNet, options);
    }
}

function createVditor(element, dotNet, options) {
    if (Vditor === undefined) {
        setTimeout(createVditor, 100, element, dotNet, options);
        return;
    }
    window.load_vditor = 2;
    delNullNodes(options);
    const vditor = new Vditor(element, {
        ...options,
        toolbar: options.toolbar ? options.toolbar.map(x => {
            if (x.constructor === String) {
                return x;
            }

            if (x.click === undefined) {
                return x;
            }

            x.click = () => dotNet.invokeMethodAsync('InvokeToolbarCallback', x.name);
            return x;
        }) : null,
        resize: {
            ...options.resize,
            after: (heightDelta) => dotNet.invokeMethodAsync('InvokeResizeAfter', heightDelta)
        },
        counter: {
            ...options.counter,
            after: (length, counter) => dotNet.invokeMethodAsync('InvokeCounterAfter', length, counter)
        },
        cache: {
            ...options.cache,
            after: (markdown) => dotNet.invokeMethodAsync('InvokeCacheAfter', markdown)
        },
        preview: {
            ...options.preview,
            actions: options.preview.actions ? options.preview.actions.map(x => {
                if (x.constructor === String) {
                    return x;
                }

                if (x.click === undefined) {
                    return x;
                }

                x.click = (value) => dotNet.invokeMethodAsync('InvokePreviewActionCallback', value);
                return x;
            }) : null,
            parse: (value) => dotNet.invokeMethodAsync('InvokePreviewParse'),
            transform: (html) => dotNet.invokeMethod('InvokePreviewTransform', html).result,
        },
        link: {
            ...options.link,
            click: (value) => dotNet.invokeMethodAsync('InvokeLinkClick', value),
        },
        image: {
            ...options.image,
            preview: (value) => dotNet.invokeMethodAsync('InvokeImagePreview', value)
        },
        hint: {
            ...options.hint,
            extend: options.hint.extend ? options.hint.extend.map(x => {
                if (x.hint === undefined) {
                    return x;
                }

                x.hint = async (value) => await dotNet.invokeMethodAsync('InvokeHintCallback', x.key, value);
                return x;
            }) : null,
        },
        comment: {
            ...options.comment,
            add: async (id, text, commentsData) => await dotNet.invokeMethodAsync('InvokeCommentAdd', id, text, commentsData),
            remove: async (ids) => await dotNet.invokeMethodAsync('InvokeCommentRemove', ids),
            scroll: async (top) => await dotNet.invokeMethodAsync('InvokeCommentScroll', top),
            adjustTop: async (commentsData) => await dotNet.invokeMethodAsync('InvokeCommentAdjustTop', commentsData),
        },
        after: () => dotNet.invokeMethodAsync('InvokeAfter'),
        input: (value) => dotNet.invokeMethodAsync('InvokeInput', value),
        focus: (value) => dotNet.invokeMethodAsync('InvokeFocus', value),
        blur: (value) => dotNet.invokeMethodAsync('InvokeBlur', value),
        keydown: (value) => dotNet.invokeMethodAsync('InvokeKeydown', {
            isTrusted: value.isTrusted,
            altKey: value.altKey,
            bubbles: value.bubbles,
            code: value.code,
            ctrlKey: value.ctrlKey,
            isComposing: value.isComposing,
            key: value.key,
            location: value.location,
            metaKey: value.metaKey,
            repeat: value.repeat,
            shiftKey: value.shiftKey,
            timeStamp: value.timeStamp,
        }),
        esc: (value) => dotNet.invokeMethodAsync('InvokeEscape', value),
        ctrlEnter: (value) => dotNet.invokeMethodAsync('InvokeCtrlEnter', value),
        select: (value) => dotNet.invokeMethodAsync('InvokeSelect', value),
        unSelect: () => dotNet.invokeMethodAsync('InvokeUnSelect'),
    })

    window.load_vditor = 3;
    const loading_element = document.getElementById("loading");
    loading_element.remove();
    return vditor;
}

export function initReadonlyVditor(element, markdown, dotNet, options) {
    if (window.load_vditor === undefined) {
        window.load_vditor = 1;
        setTimeout(createReadonlyVditor, 100, element, markdown, dotNet, options);
    }
}

function createReadonlyVditor(element, markdown, dotNet, options) {
    if (Vditor === undefined) {
        setTimeout(createReadonlyVditor, 100, element, markdown, dotNet, options);
        return;
    }
    window.load_vditor = 2;
    delNullNodes(options);
    Vditor.preview(document.getElementById(element), markdown, {
        ...options,
        transform: (html) => dotNet.invokeMethod('InvokePreviewTransform', html).result,
        after: () => dotNet.invokeMethodAsync('InvokeAfter'),
    });
    const loading_element = document.getElementById("loading");
    loading_element.remove();
}