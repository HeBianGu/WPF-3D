using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLCompositeDataSetWriterHelper
	/// </summary>
	/// <remarks>
	///  a helper class used by vtkXMLWriter2 subclasses that write composite
	///        datasets.
	///
	/// vtkXMLCompositeDataSetWriterHelper is a helper class intended to be used by
	/// subclasses of vtkXMLWriter2 that want to write composite datasets. It
	/// consolidates the logic to write individual datasets for leaf nodes into
	/// separate files.
	/// </remarks>
	// Token: 0x02000133 RID: 307
	public class vtkXMLCompositeDataSetWriterHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003D79 RID: 15737 RVA: 0x00059D76 File Offset: 0x00057F76
		static vtkXMLCompositeDataSetWriterHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLCompositeDataSetWriterHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataSetWriterHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003D7A RID: 15738 RVA: 0x00059D9E File Offset: 0x00057F9E
		public vtkXMLCompositeDataSetWriterHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003D7B RID: 15739
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D7C RID: 15740 RVA: 0x00059DAC File Offset: 0x00057FAC
		public new static vtkXMLCompositeDataSetWriterHelper New()
		{
			vtkXMLCompositeDataSetWriterHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D7D RID: 15741 RVA: 0x00059E00 File Offset: 0x00058000
		public vtkXMLCompositeDataSetWriterHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003D7E RID: 15742 RVA: 0x00059E44 File Offset: 0x00058044
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003D7F RID: 15743
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D80 RID: 15744 RVA: 0x00059E50 File Offset: 0x00058050
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003D81 RID: 15745
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D82 RID: 15746 RVA: 0x00059E70 File Offset: 0x00058070
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003D83 RID: 15747
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_GetWriter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer using this helper. This is reference counted. So caller
		/// should avoid cycles explicitly.
		/// </summary>
		// Token: 0x06003D84 RID: 15748 RVA: 0x00059E8C File Offset: 0x0005808C
		public virtual vtkXMLWriterBase GetWriter()
		{
			vtkXMLWriterBase vtkXMLWriterBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_GetWriter_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriterBase = (vtkXMLWriterBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriterBase.Register(null);
				}
			}
			return vtkXMLWriterBase;
		}

		// Token: 0x06003D85 RID: 15749
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataSetWriterHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D86 RID: 15750 RVA: 0x00059EFC File Offset: 0x000580FC
		public override int IsA(string type)
		{
			return vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003D87 RID: 15751
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataSetWriterHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D88 RID: 15752 RVA: 0x00059F1C File Offset: 0x0005811C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_IsTypeOf_05(type);
		}

		// Token: 0x06003D89 RID: 15753
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D8A RID: 15754 RVA: 0x00059F38 File Offset: 0x00058138
		public new vtkXMLCompositeDataSetWriterHelper NewInstance()
		{
			vtkXMLCompositeDataSetWriterHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003D8B RID: 15755
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D8C RID: 15756 RVA: 0x00059F94 File Offset: 0x00058194
		public new static vtkXMLCompositeDataSetWriterHelper SafeDownCast(vtkObjectBase o)
		{
			vtkXMLCompositeDataSetWriterHelper vtkXMLCompositeDataSetWriterHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLCompositeDataSetWriterHelper = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLCompositeDataSetWriterHelper.Register(null);
				}
			}
			return vtkXMLCompositeDataSetWriterHelper;
		}

		// Token: 0x06003D8D RID: 15757
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLCompositeDataSetWriterHelper_SetWriter_09(HandleRef pThis, HandleRef writer);

		/// <summary>
		/// Get/Set the writer using this helper. This is reference counted. So caller
		/// should avoid cycles explicitly.
		/// </summary>
		// Token: 0x06003D8E RID: 15758 RVA: 0x0005A014 File Offset: 0x00058214
		public void SetWriter(vtkXMLWriterBase writer)
		{
			vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_SetWriter_09(base.GetCppThis(), (writer == null) ? default(HandleRef) : writer.GetCppThis());
		}

		// Token: 0x06003D8F RID: 15759
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkXMLCompositeDataSetWriterHelper_WriteDataSet_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, [MarshalAs(UnmanagedType.LPUTF8Str)] string prefix, HandleRef data);

		/// <summary>
		/// Write a specific dataset to a file. The dataset cannot be a composite
		/// dataset. The implementation uses `vtkXMLDataObjectWriter` to find a writer
		/// to use. Internally, writers are cached and will be reused when same type of
		/// data is being written out multiple times.
		///
		/// The filename is created using the `path` and `prefix`. The prefix is
		/// extended with a `.&lt;ext&gt;` where the `&lt;ext&gt;` is dictated by the writer used.
		/// `vtkXMLWriterBase::GetDefaultFileExtension` is used to obtain the
		/// extension to use for the file written out.
		///
		/// On success, returns `&lt;prefix&gt;.&lt;ext&gt;`, otherwise an empty string is
		/// returned.
		/// </summary>
		// Token: 0x06003D90 RID: 15760 RVA: 0x0005A044 File Offset: 0x00058244
		public string WriteDataSet(string path, string prefix, vtkDataObject data)
		{
			return vtkXMLCompositeDataSetWriterHelper.vtkXMLCompositeDataSetWriterHelper_WriteDataSet_10(base.GetCppThis(), path, prefix, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006A2 RID: 1698
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataSetWriterHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006A3 RID: 1699
		public new static readonly string MRClassNameKey = "class vtkXMLCompositeDataSetWriterHelper";
	}
}
