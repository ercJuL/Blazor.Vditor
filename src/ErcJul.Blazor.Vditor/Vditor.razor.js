const delNullNodes = (option = {}) => {
    if (option === null || option === undefined) return option;
    Object.keys(option).forEach((key) => {
        let value = option[key];
        value && typeof value === 'object' && delNullNodes(value);
        (value === null || value === undefined) && delete option[key];
    })
}

export function initVditor(element, dotNet, options) {
    let elementId = element.constructor === String ? element : element.id;
    if (window.ercjul_vditor?.[elementId]?.load_vditor === undefined) {
        window.ercjul_vditor = {
            ...window.ercjul_vditor,
            [elementId]: {
                load_vditor: 1
            }
        }
        setTimeout(createVditor, 100, element, dotNet, options);
    }
}

function createVditor(element, dotNet, options) {
    if (window.Vditor === undefined) {
        setTimeout(createVditor, 100, element, dotNet, options);
        return;
    }
    window.ercjul_vditor[element.constructor === String ? element : element.id].load_vditor = 2;
    delNullNodes(options);
    const vditor = new window.Vditor(element, options ? {
        ...options,
        toolbar: options.toolbar?.map(x => {
            if (x.constructor === String) {
                return x;
            }

            if (x.click === undefined) {
                return x;
            }

            x.click = () => dotNet.invokeMethodAsync('InvokeToolbarCallback', x.name);
            return x;
        }),
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
            actions: options.preview?.actions?.map(x => {
                if (x.constructor === String) {
                    return x;
                }

                if (x.click === undefined) {
                    return x;
                }

                x.click = (value) => dotNet.invokeMethodAsync('InvokePreviewActionCallback', value);
                return x;
            }),
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
            extend: options.hint?.extend?.map(x => {
                if (x.hint === undefined) {
                    return x;
                }

                x.hint = async (value) => await dotNet.invokeMethodAsync('InvokeHintCallback', x.key, value);
                return x;
            }),
        },
        comment: {
            ...options.comment,
            add: async (id, text, commentsData) => await dotNet.invokeMethodAsync('InvokeCommentAdd', id, text, commentsData),
            remove: async (ids) => await dotNet.invokeMethodAsync('InvokeCommentRemove', ids),
            scroll: async (top) => await dotNet.invokeMethodAsync('InvokeCommentScroll', top),
            adjustTop: async (commentsData) => await dotNet.invokeMethodAsync('InvokeCommentAdjustTop', commentsData),
        },
        after: async () => {
            const loading_element = document.getElementById((element.constructor === String ? element : element.id) + "-loading");
            loading_element.remove();
            await dotNet.invokeMethodAsync('InvokeAfter')
        },
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
    } : null);

    window.ercjul_vditor[element.constructor === String ? element : element.id].load_vditor = 3;
    return vditor;
}

export function initReadonlyVditor(element, markdown, dotNet, options) {
    let elementId = element.constructor === String ? element : element.id;
    if (window.ercjul_vditor?.[elementId]?.load_vditor === undefined) {
        window.ercjul_vditor = {
            ...window.ercjul_vditor,
            [elementId]: {
                load_vditor: 1
            }
        }
        setTimeout(createReadonlyVditor, 100, element, markdown, dotNet, options);
    }
}

function createReadonlyVditor(element, markdown, dotNet, options) {
    if (window.Vditor === undefined) {
        setTimeout(createReadonlyVditor, 100, element, markdown, dotNet, options);
        return;
    }
    window.ercjul_vditor[element.constructor === String ? element : element.id].load_vditor = 2;
    delNullNodes(options);
    window.Vditor.preview(document.getElementById(element), markdown, options ? {
        ...options,
        transform: (html) => dotNet.invokeMethod('InvokePreviewTransform', html).result,
        after: async () => {
            const loading_element = document.getElementById((element.constructor === String ? element : element.id) + "-loading");
            loading_element.remove();
            await dotNet.invokeMethodAsync('InvokeAfter')
        },
    } : null);
}