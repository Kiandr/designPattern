public static class SignleTone {

    private static SignleTone instance;
    private long time;

    public long getTime() {
        return time;
    }

    public SignleTone() {
        time = new Date().getTime();
    }

    public SignleTone SignleInstanceEager() {
        instance = new SignleTone();
        return instance;
    }

    public SignleTone SignleInstanceLazy() {
        if (instance == null) {
            instance = new SignleTone();
        }
        return instance;
    }

    public SignleTone SignleToneThreadSafe() {
        if (instance == null) {
            synchronized (SignleTone.class) {
                if (instance == null) {
                    instance = new SignleTone();
                }
            }
        }
        return instance;
    }

    public synchronized SignleTone SingleToneThreadSafeSync() {
        
        if (instance == null) {
            instance = new SignleTone();
        }
        return instance;
    }
}