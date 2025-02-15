//
// ExternalUrl.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct ExternalUrl: Codable {

    /** The name. */
    public var name: String?
    /** The type of the item. */
    public var url: String?

    public init(name: String? = nil, url: String? = nil) {
        self.name = name
        self.url = url
    }

    public enum CodingKeys: String, CodingKey { 
        case name = "Name"
        case url = "Url"
    }

}
