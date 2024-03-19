using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  Represent an URI component
	///
	/// An URI can have an empty but defined component.
	/// This applies to authority, path, query and fragment.
	/// This is mainly used for strong string reconstruction, example:
	/// `vtkURI::Parse("file://?#")-&gt;ToString()` must return `"file://?#"`,
	/// all components are empty, but defined, so they must be restored
	/// when recomposition the URI string representation.
	/// URI path is always defined for a valid URI.
	/// </remarks>
	// Token: 0x02000735 RID: 1845
	public class vtkURI : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060133B3 RID: 78771 RVA: 0x001B30FA File Offset: 0x001B12FA
		static vtkURI()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkURI.MRClassNameKey, Type.GetType("Kitware.VTK.vtkURI"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060133B4 RID: 78772 RVA: 0x001B3122 File Offset: 0x001B1322
		public vtkURI(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060133B5 RID: 78773
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief Construct a new vtkURI
		///
		/// Default URI as a defined but empty path. Other components are undefined.
		///
		/// @return New URI instance
		/// </summary>
		// Token: 0x060133B6 RID: 78774 RVA: 0x001B3130 File Offset: 0x001B1330
		public new static vtkURI New()
		{
			vtkURI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURI.vtkURI_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkURI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// @brief Construct a new vtkURI
		///
		/// Default URI as a defined but empty path. Other components are undefined.
		///
		/// @return New URI instance
		/// </summary>
		// Token: 0x060133B7 RID: 78775 RVA: 0x001B3184 File Offset: 0x001B1384
		public vtkURI() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkURI.vtkURI_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060133B8 RID: 78776 RVA: 0x001B31C8 File Offset: 0x001B13C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060133B9 RID: 78777
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkURI_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133BA RID: 78778 RVA: 0x001B31D4 File Offset: 0x001B13D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkURI.vtkURI_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060133BB RID: 78779
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkURI_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133BC RID: 78780 RVA: 0x001B31F4 File Offset: 0x001B13F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkURI.vtkURI_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060133BD RID: 78781
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkURI_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133BE RID: 78782 RVA: 0x001B3210 File Offset: 0x001B1410
		public override int IsA(string type)
		{
			return vtkURI.vtkURI_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060133BF RID: 78783
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsAbsolute_04(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133C0 RID: 78784 RVA: 0x001B3230 File Offset: 0x001B1430
		public bool IsAbsolute()
		{
			return vtkURI.vtkURI_IsAbsolute_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060133C1 RID: 78785
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsEmpty_05(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133C2 RID: 78786 RVA: 0x001B3258 File Offset: 0x001B1458
		public bool IsEmpty()
		{
			return vtkURI.vtkURI_IsEmpty_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060133C3 RID: 78787
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsFull_06(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133C4 RID: 78788 RVA: 0x001B3280 File Offset: 0x001B1480
		public bool IsFull()
		{
			return vtkURI.vtkURI_IsFull_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060133C5 RID: 78789
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsReference_07(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133C6 RID: 78790 RVA: 0x001B32A8 File Offset: 0x001B14A8
		public bool IsReference()
		{
			return vtkURI.vtkURI_IsReference_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060133C7 RID: 78791
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsRelative_08(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133C8 RID: 78792 RVA: 0x001B32D0 File Offset: 0x001B14D0
		public bool IsRelative()
		{
			return vtkURI.vtkURI_IsRelative_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060133C9 RID: 78793
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkURI_IsSameDocRef_09(HandleRef pThis);

		/// <summary>
		/// @brief URI types determination
		///
		/// URI can be either:
		/// - A full [URI](https://datatracker.ietf.org/doc/html/rfc3986#section-3):
		///   It has a scheme.
		/// - an [URI reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.1):
		///   an URI that is either a relative reference or a full URI.
		/// - a [relative reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.2),
		///   an URI that refers to data that has to be resolved from a base URI prior to loading.
		///   It does not define a scheme but defines at least one other component.
		/// - an [absolute URI](https://datatracker.ietf.org/doc/html/rfc3986#section-4.3),
		///   an URI that can be used as a base URI.
		///   It defines a scheme and no fragment. It may define other components.
		/// - a [same-document reference](https://datatracker.ietf.org/doc/html/rfc3986#section-4.4):
		///   an URI that defines only a fragment.
		/// - An empty URI
		/// </summary>
		// Token: 0x060133CA RID: 78794 RVA: 0x001B32F8 File Offset: 0x001B14F8
		public bool IsSameDocRef()
		{
			return vtkURI.vtkURI_IsSameDocRef_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060133CB RID: 78795
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkURI_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133CC RID: 78796 RVA: 0x001B3320 File Offset: 0x001B1520
		public new static int IsTypeOf(string type)
		{
			return vtkURI.vtkURI_IsTypeOf_10(type);
		}

		// Token: 0x060133CD RID: 78797
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURI_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133CE RID: 78798 RVA: 0x001B333C File Offset: 0x001B153C
		public new vtkURI NewInstance()
		{
			vtkURI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURI.vtkURI_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkURI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060133CF RID: 78799
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkURI_PercentDecode_13([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		///  Calls `PercentDecode(str.data(), str.size())`
		///
		/// @param str Input string to decode, may be empty.
		/// @return Decoded string from `str`
		/// </summary>
		// Token: 0x060133D0 RID: 78800 RVA: 0x001B3398 File Offset: 0x001B1598
		public static string PercentDecode(string str)
		{
			return vtkURI.vtkURI_PercentDecode_13(str);
		}

		// Token: 0x060133D1 RID: 78801
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkURI_PercentDecode_14([MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong size);

		/// <summary>
		/// @brief Decode percent-encoded values from given string
		///
		/// [Percent-encoded values](https://datatracker.ietf.org/doc/html/rfc3986#section-2.1)
		/// are used to store reserved characters in URIs.
		///
		/// This function decode `str`, replacing `%HH` values with their real value.
		///
		/// @param str Input string to decode, may be null if size is 0.
		/// @param size Input string size, may be 0.
		/// @return Decoded string from `str`
		/// </summary>
		// Token: 0x060133D2 RID: 78802 RVA: 0x001B33B4 File Offset: 0x001B15B4
		public static string PercentDecode(string str, ulong size)
		{
			return vtkURI.vtkURI_PercentDecode_14(str, size);
		}

		// Token: 0x060133D3 RID: 78803
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkURI_PercentEncode_15([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		///  Calls `PercentEncode(str.data(), str.size())`
		///
		/// @param str Input string to encode, may be empty.
		/// @return Encodes string from `str`
		/// </summary>
		// Token: 0x060133D4 RID: 78804 RVA: 0x001B33D0 File Offset: 0x001B15D0
		public static string PercentEncode(string str)
		{
			return vtkURI.vtkURI_PercentEncode_15(str);
		}

		// Token: 0x060133D5 RID: 78805
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkURI_PercentEncode_16([MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong size);

		/// <summary>
		/// @brief Encode a string into an URI compatible, percent-encoded, string
		///
		/// Transform all bytes in `str` that are **not** part of
		/// ["reserved"](https://datatracker.ietf.org/doc/html/rfc3986#section-2.2)
		/// or ["unreserved"](https://datatracker.ietf.org/doc/html/rfc3986#section-2.3)
		/// character sets into
		/// [percent-encoded values](https://datatracker.ietf.org/doc/html/rfc3986#section-2.1).
		///
		/// Note:
		/// - All '%' in `str` will be replaced with "%25",
		///   even if they already represent a percent-encoded value
		///
		/// @param str Input string to encode, may be null if size is 0.
		/// @param size Input string size, may be 0.
		/// @return Encoded string from `str`
		/// </summary>
		// Token: 0x060133D6 RID: 78806 RVA: 0x001B33EC File Offset: 0x001B15EC
		public static string PercentEncode(string str, ulong size)
		{
			return vtkURI.vtkURI_PercentEncode_16(str, size);
		}

		// Token: 0x060133D7 RID: 78807
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkURI_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133D8 RID: 78808 RVA: 0x001B3408 File Offset: 0x001B1608
		public new static vtkURI SafeDownCast(vtkObjectBase o)
		{
			vtkURI vtkURI = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkURI.vtkURI_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkURI = (vtkURI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkURI.Register(null);
				}
			}
			return vtkURI;
		}

		// Token: 0x060133D9 RID: 78809
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkURI_ToString_18(HandleRef pThis);

		/// <summary>
		/// @brief Construct the string representation of the URI
		///
		/// @return a string representing the URI
		/// </summary>
		// Token: 0x060133DA RID: 78810 RVA: 0x001B3488 File Offset: 0x001B1688
		public string ToStringWrapper()
		{
			return vtkURI.vtkURI_ToString_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001636 RID: 5686
		public new const string MRFullTypeName = "Kitware.VTK.vtkURI";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001637 RID: 5687
		public new static readonly string MRClassNameKey = "class vtkURI";
	}
}
