﻿using System.Xml.Serialization;
using X.Web.RSS.Structure.Validators;

namespace X.Web.RSS.Structure;

/// <summary>
/// The purpose of the 'textInput' element is something of a mystery. 
///   You can use it to specify a search engine box. Or to allow a reader 
///   to provide feedback. Most aggregators ignore it.
/// </summary>
public class RssTextInput
{
    /// <summary>
    ///   Gets or sets explains the text input area.
    /// </summary>
    [XmlElement("description")]
    public string Description { get; set; }

    /// <summary>
    ///   Gets or sets the URL of the CGI script that processes text input requests.
    /// </summary>
    [XmlElement("link")]
    public RssUrl Link { get; set; }

    /// <summary>
    ///   Gets or sets the name of the text object in the text input area.
    /// </summary>
    [XmlElement("name")]
    public string Name { get; set; }

    /// <summary>
    ///   Gets or sets the label of the Submit button in the text input area.
    /// </summary>
    [XmlElement("title")]
    public string Title { get; set; }
}