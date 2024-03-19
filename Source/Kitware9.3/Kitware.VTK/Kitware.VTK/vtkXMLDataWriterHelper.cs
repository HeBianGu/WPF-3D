using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLDataWriterHelper
	/// </summary>
	/// <remarks>
	///  helper for vtkXMLWriter2 and subclasses
	///
	/// vtkXMLDataWriterHelper is intended to be a helper class used by vtkXMLWriter2
	/// and subclasses to use to write the XML to a file. Currently, this is simply a
	/// subclass of vtkXMLWriter with some minimal API exposed. The ultimate goal is
	/// to move logic to write XML data to this class and remove the reliance on
	/// vtkXMLWriter. To get things off the ground quickly, this is kept as a
	/// subclass of vtkXMLWriter for now.
	/// </remarks>
	// Token: 0x0200013B RID: 315
	public class vtkXMLDataWriterHelper : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003E13 RID: 15891 RVA: 0x0005A95E File Offset: 0x00058B5E
		static vtkXMLDataWriterHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataWriterHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataWriterHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003E14 RID: 15892 RVA: 0x0005A986 File Offset: 0x00058B86
		public vtkXMLDataWriterHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003E15 RID: 15893
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataWriterHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E16 RID: 15894 RVA: 0x0005A994 File Offset: 0x00058B94
		public new static vtkXMLDataWriterHelper New()
		{
			vtkXMLDataWriterHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E17 RID: 15895 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		public vtkXMLDataWriterHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003E18 RID: 15896 RVA: 0x0005AA2C File Offset: 0x00058C2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003E19 RID: 15897
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLDataWriterHelper_AddGlobalFieldData_01(HandleRef pThis, HandleRef dataset);

		/// <summary>
		/// Adds global field data for composite dataset.
		/// </summary>
		// Token: 0x06003E1A RID: 15898 RVA: 0x0005AA38 File Offset: 0x00058C38
		public bool AddGlobalFieldData(vtkCompositeDataSet dataset)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_AddGlobalFieldData_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis()) != 0;
		}

		// Token: 0x06003E1B RID: 15899
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLDataWriterHelper_AddXML_02(HandleRef pThis, HandleRef xmlElement);

		/// <summary>
		/// Serialize and add an XML dom described by the `xmlElement` to the file.
		/// </summary>
		// Token: 0x06003E1C RID: 15900 RVA: 0x0005AA74 File Offset: 0x00058C74
		public bool AddXML(vtkXMLDataElement xmlElement)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_AddXML_02(base.GetCppThis(), (xmlElement == null) ? default(HandleRef) : xmlElement.GetCppThis()) != 0;
		}

		// Token: 0x06003E1D RID: 15901
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLDataWriterHelper_BeginWriting_03(HandleRef pThis);

		/// <summary>
		/// The writing process is split into 4 parts:
		/// 1. `OpenFile` opens the file for writing.
		/// 2. `BeginWriting` begins writing by adding header.
		/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
		/// 4. `EndWriting` ends the writing, adding any footers as needed.
		/// </summary>
		// Token: 0x06003E1E RID: 15902 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		public bool BeginWriting()
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_BeginWriting_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06003E1F RID: 15903
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLDataWriterHelper_EndWriting_04(HandleRef pThis);

		/// <summary>
		/// The writing process is split into 4 parts:
		/// 1. `OpenFile` opens the file for writing.
		/// 2. `BeginWriting` begins writing by adding header.
		/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
		/// 4. `EndWriting` ends the writing, adding any footers as needed.
		/// </summary>
		// Token: 0x06003E20 RID: 15904 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		public bool EndWriting()
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_EndWriting_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06003E21 RID: 15905
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataWriterHelper_GetDefaultFileExtension_05(HandleRef pThis);

		/// <summary>
		/// These methods should be used by the caller to provide necessary information
		/// to the helper to generate a valid header. This is currently necessary since
		/// we are making this class reused parts of vtkXMLWriter. When than dependence
		/// is severed, this API will likely change.
		/// </summary>
		// Token: 0x06003E22 RID: 15906 RVA: 0x0005AB00 File Offset: 0x00058D00
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_GetDefaultFileExtension_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003E23 RID: 15907
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E24 RID: 15908 RVA: 0x0005AB3C File Offset: 0x00058D3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06003E25 RID: 15909
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E26 RID: 15910 RVA: 0x0005AB5C File Offset: 0x00058D5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06003E27 RID: 15911
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataWriterHelper_GetWriter_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer using this helper. Attributes from the writer are used
		/// to control how data is written out.
		/// </summary>
		// Token: 0x06003E28 RID: 15912 RVA: 0x0005AB78 File Offset: 0x00058D78
		public virtual vtkXMLWriter2 GetWriter()
		{
			vtkXMLWriter2 vtkXMLWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_GetWriter_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriter = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriter.Register(null);
				}
			}
			return vtkXMLWriter;
		}

		// Token: 0x06003E29 RID: 15913
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataWriterHelper_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E2A RID: 15914 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		public override int IsA(string type)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06003E2B RID: 15915
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataWriterHelper_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E2C RID: 15916 RVA: 0x0005AC08 File Offset: 0x00058E08
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_IsTypeOf_10(type);
		}

		// Token: 0x06003E2D RID: 15917
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataWriterHelper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E2E RID: 15918 RVA: 0x0005AC24 File Offset: 0x00058E24
		public new vtkXMLDataWriterHelper NewInstance()
		{
			vtkXMLDataWriterHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E2F RID: 15919
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLDataWriterHelper_OpenFile_13(HandleRef pThis);

		/// <summary>
		/// The writing process is split into 4 parts:
		/// 1. `OpenFile` opens the file for writing.
		/// 2. `BeginWriting` begins writing by adding header.
		/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
		/// 4. `EndWriting` ends the writing, adding any footers as needed.
		/// </summary>
		// Token: 0x06003E30 RID: 15920 RVA: 0x0005AC80 File Offset: 0x00058E80
		public bool OpenFile()
		{
			return vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_OpenFile_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06003E31 RID: 15921
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataWriterHelper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E32 RID: 15922 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		public new static vtkXMLDataWriterHelper SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataWriterHelper vtkXMLDataWriterHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataWriterHelper = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataWriterHelper.Register(null);
				}
			}
			return vtkXMLDataWriterHelper;
		}

		// Token: 0x06003E33 RID: 15923
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataWriterHelper_SetDataSetName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// These methods should be used by the caller to provide necessary information
		/// to the helper to generate a valid header. This is currently necessary since
		/// we are making this class reused parts of vtkXMLWriter. When than dependence
		/// is severed, this API will likely change.
		/// </summary>
		// Token: 0x06003E34 RID: 15924 RVA: 0x0005AD27 File Offset: 0x00058F27
		public void SetDataSetName(string name)
		{
			vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_SetDataSetName_15(base.GetCppThis(), name);
		}

		// Token: 0x06003E35 RID: 15925
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataWriterHelper_SetDataSetVersion_16(HandleRef pThis, int major, int minor);

		/// <summary>
		/// These methods should be used by the caller to provide necessary information
		/// to the helper to generate a valid header. This is currently necessary since
		/// we are making this class reused parts of vtkXMLWriter. When than dependence
		/// is severed, this API will likely change.
		/// </summary>
		// Token: 0x06003E36 RID: 15926 RVA: 0x0005AD37 File Offset: 0x00058F37
		public void SetDataSetVersion(int major, int minor)
		{
			vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_SetDataSetVersion_16(base.GetCppThis(), major, minor);
		}

		// Token: 0x06003E37 RID: 15927
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataWriterHelper_SetWriter_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the writer using this helper. Attributes from the writer are used
		/// to control how data is written out.
		/// </summary>
		// Token: 0x06003E38 RID: 15928 RVA: 0x0005AD48 File Offset: 0x00058F48
		public void SetWriter(vtkXMLWriter2 arg0)
		{
			vtkXMLDataWriterHelper.vtkXMLDataWriterHelper_SetWriter_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BA RID: 1722
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataWriterHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BB RID: 1723
		public new static readonly string MRClassNameKey = "class vtkXMLDataWriterHelper";
	}
}
