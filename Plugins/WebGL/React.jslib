mergeInto(LibraryManager.library, {
  OnMessage: function (message) {
    window.dispatchReactUnityEvent("OnMessage", UTF8ToString(message));
  },
});