import util from "../utils";
class ApplicationService {
    getServiceFramework(controller) {
        let sf = util.utilities.sf;
        sf.controller = controller;
        return sf;
    }

    getSettings(callback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.get("GetSettings", {}, callback);
    }

    updateGeneralSettings(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("UpdateGeneralSettings", payload, failureCallback, callback);
    }    

    updateAdvancedSettings(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("UpdateAdvancedSettings", payload, failureCallback, callback);
    }

    updateProfileMapping(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("UpdateProfileMapping", payload, failureCallback, callback);
    }

    deleteProfileMapping(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("DeleteProfileMapping", payload, failureCallback, callback);
    }
    getProfileSettings(callback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.get("GetProfileSettings", {}, callback);
    }

    getProfileProperties(callback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.get("GetProfileProperties", {}, callback);
    }

    getRoleMappingSettings(callback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.get("GetRoleMappingSettings", {}, callback);
    }

    getAvailableRoles(callback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.get("GetAvailableRoles", {}, callback);
    }

    updateRoleMapping(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("UpdateRoleMapping", payload, failureCallback, callback);
    }

    deleteRoleMapping(payload, callback, failureCallback) {
        const sf = this.getServiceFramework("AzureADB2C");        
        sf.post("DeleteRoleMapping", payload, failureCallback, callback);
    }

}
const applicationService = new ApplicationService();
export default applicationService;