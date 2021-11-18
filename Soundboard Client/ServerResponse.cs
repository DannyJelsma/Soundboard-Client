namespace Soundboard_Client {
    class ServerResponse<T> {

        private bool success;
        private string message;
        private T result;
        private int httpResponse;

        public ServerResponse(bool success, T result) {
            this.success = success;
            this.result = result;
            this.message = null;
            this.httpResponse = 200;
        }

        public ServerResponse(bool success, int httpResponse, string message) {
            this.success = success;
            this.message = message;
            this.result = default;
            this.httpResponse = httpResponse;
        }

        public string GetMessage() {
            return message;
        }

        public bool IsSuccess() {
            return success;
        }

        public T GetResult() {
            return result;
        }

        public int getStatusCode() {
            return this.httpResponse;
        }
    }
}
