public static sealed class singleTone{
    private static singleTone instance = NULL;
    private static object lockThis = NULL;
    private singleTone(){};
    public static singleTone getInstanceEager(){
        this.instance = new singleTone();
            return this.instance;
    }
    public static singleTone getInstanceLazy(){
        if (instance == NULL) this.instance = new singleTone();
        return this.instance;
    }
    public static singleTone getInstanceThreadSafe(){
     lock (lockThis)
     {
        if (instance == NULL) this.instance = new singleTone();
        return this.instance;
     }
    }
}
