package #packageName#;

public class #className# {
#properties#
    private #type# #prop#;

    public #className#(){}
    
#getter#
    public #type# #getProp#() {
        return #prop#;
    }

#setter#
    public void #setProp#(#type# #prop#) {
        this.#prop# = #prop#;
    }
}
