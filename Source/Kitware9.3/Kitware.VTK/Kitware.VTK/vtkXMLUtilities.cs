using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUtilities
	/// </summary>
	/// <remarks>
	///    XML utilities.
	///
	/// vtkXMLUtilities provides XML-related convenience functions.
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataElement
	/// </seealso>
	// Token: 0x020006ED RID: 1773
	public class vtkXMLUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012B03 RID: 76547 RVA: 0x001A4967 File Offset: 0x001A2B67
		static vtkXMLUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012B04 RID: 76548 RVA: 0x001A498F File Offset: 0x001A2B8F
		public vtkXMLUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012B05 RID: 76549
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B06 RID: 76550 RVA: 0x001A49A0 File Offset: 0x001A2BA0
		public new static vtkXMLUtilities New()
		{
			vtkXMLUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B07 RID: 76551 RVA: 0x001A49F4 File Offset: 0x001A2BF4
		public vtkXMLUtilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLUtilities.vtkXMLUtilities_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012B08 RID: 76552 RVA: 0x001A4A38 File Offset: 0x001A2C38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012B09 RID: 76553
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUtilities_FactorElements_01(HandleRef tree);

		/// <summary>
		/// Factor and unfactor a tree. This operation looks for duplicate elements
		/// in the tree, and replace them with references to a pool of elements.
		/// Unfactoring a non-factored element is harmless.
		/// </summary>
		// Token: 0x06012B0A RID: 76554 RVA: 0x001A4A44 File Offset: 0x001A2C44
		public static void FactorElements(vtkXMLDataElement tree)
		{
			vtkXMLUtilities.vtkXMLUtilities_FactorElements_01((tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06012B0B RID: 76555
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B0C RID: 76556 RVA: 0x001A4A70 File Offset: 0x001A2C70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012B0D RID: 76557
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUtilities_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B0E RID: 76558 RVA: 0x001A4A90 File Offset: 0x001A2C90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012B0F RID: 76559
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUtilities_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B10 RID: 76560 RVA: 0x001A4AAC File Offset: 0x001A2CAC
		public override int IsA(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012B11 RID: 76561
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUtilities_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B12 RID: 76562 RVA: 0x001A4ACC File Offset: 0x001A2CCC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUtilities.vtkXMLUtilities_IsTypeOf_05(type);
		}

		// Token: 0x06012B13 RID: 76563
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUtilities_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B14 RID: 76564 RVA: 0x001A4AE8 File Offset: 0x001A2CE8
		public new vtkXMLUtilities NewInstance()
		{
			vtkXMLUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012B15 RID: 76565
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUtilities_ReadElementFromFile_08([MarshalAs(UnmanagedType.LPUTF8Str)] string filename, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Read a vtkXMLDataElement from a stream, string or file.
		/// The 'encoding' parameter will be used to set the internal encoding of the
		/// attributes of the data elements created by those functions (conversion
		/// from the XML stream encoding to that new encoding will be performed
		/// automatically). If set to VTK_ENCODING_NONE, the encoding won't be
		/// changed and will default to the default vtkXMLDataElement encoding.
		/// Return the root element on success, nullptr otherwise.
		/// Note that you have to call Delete() on the element returned by that
		/// function to ensure it is freed properly.
		/// </summary>
		// Token: 0x06012B16 RID: 76566 RVA: 0x001A4B44 File Offset: 0x001A2D44
		public static vtkXMLDataElement ReadElementFromFile(string filename, int encoding)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_ReadElementFromFile_08(filename, encoding, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x06012B17 RID: 76567
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUtilities_ReadElementFromString_09([MarshalAs(UnmanagedType.LPUTF8Str)] string str, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Read a vtkXMLDataElement from a stream, string or file.
		/// The 'encoding' parameter will be used to set the internal encoding of the
		/// attributes of the data elements created by those functions (conversion
		/// from the XML stream encoding to that new encoding will be performed
		/// automatically). If set to VTK_ENCODING_NONE, the encoding won't be
		/// changed and will default to the default vtkXMLDataElement encoding.
		/// Return the root element on success, nullptr otherwise.
		/// Note that you have to call Delete() on the element returned by that
		/// function to ensure it is freed properly.
		/// </summary>
		// Token: 0x06012B18 RID: 76568 RVA: 0x001A4BB0 File Offset: 0x001A2DB0
		public static vtkXMLDataElement ReadElementFromString(string str, int encoding)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_ReadElementFromString_09(str, encoding, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x06012B19 RID: 76569
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUtilities_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B1A RID: 76570 RVA: 0x001A4C1C File Offset: 0x001A2E1C
		public new static vtkXMLUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUtilities vtkXMLUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUtilities.vtkXMLUtilities_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUtilities = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUtilities.Register(null);
				}
			}
			return vtkXMLUtilities;
		}

		// Token: 0x06012B1B RID: 76571
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUtilities_UnFactorElements_11(HandleRef tree);

		/// <summary>
		/// Factor and unfactor a tree. This operation looks for duplicate elements
		/// in the tree, and replace them with references to a pool of elements.
		/// Unfactoring a non-factored element is harmless.
		/// </summary>
		// Token: 0x06012B1C RID: 76572 RVA: 0x001A4C9C File Offset: 0x001A2E9C
		public static void UnFactorElements(vtkXMLDataElement tree)
		{
			vtkXMLUtilities.vtkXMLUtilities_UnFactorElements_11((tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400158C RID: 5516
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400158D RID: 5517
		public new static readonly string MRClassNameKey = "class vtkXMLUtilities";
	}
}
