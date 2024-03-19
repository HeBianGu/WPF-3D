using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLPartitionedDataSetCollectionWriter
	/// </summary>
	/// <remarks>
	///  writer for vtkPartitionedDataSetCollection.
	///
	/// vtkXMLPartitionedDataSetCollectionWriter is a writer for vtkPartitionedDataSetCollection.
	/// This writer supports distributed use-cases as well. Use `SetController` to set the
	/// controller to use in case of distributed execution. In that case, the meta-file is written
	/// only on the root node.
	/// </remarks>
	// Token: 0x0200013D RID: 317
	public class vtkXMLPartitionedDataSetCollectionWriter : vtkXMLWriter2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003E54 RID: 15956 RVA: 0x0005B01B File Offset: 0x0005921B
		static vtkXMLPartitionedDataSetCollectionWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPartitionedDataSetCollectionWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPartitionedDataSetCollectionWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003E55 RID: 15957 RVA: 0x0005B043 File Offset: 0x00059243
		public vtkXMLPartitionedDataSetCollectionWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003E56 RID: 15958
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E57 RID: 15959 RVA: 0x0005B054 File Offset: 0x00059254
		public new static vtkXMLPartitionedDataSetCollectionWriter New()
		{
			vtkXMLPartitionedDataSetCollectionWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetCollectionWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E58 RID: 15960 RVA: 0x0005B0A8 File Offset: 0x000592A8
		public vtkXMLPartitionedDataSetCollectionWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003E59 RID: 15961 RVA: 0x0005B0EC File Offset: 0x000592EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003E5A RID: 15962
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003E5B RID: 15963 RVA: 0x0005B0F8 File Offset: 0x000592F8
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003E5C RID: 15964
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetCollectionWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E5D RID: 15965 RVA: 0x0005B134 File Offset: 0x00059334
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003E5E RID: 15966
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetCollectionWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E5F RID: 15967 RVA: 0x0005B154 File Offset: 0x00059354
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003E60 RID: 15968
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetCollectionWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E61 RID: 15969 RVA: 0x0005B170 File Offset: 0x00059370
		public override int IsA(string type)
		{
			return vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003E62 RID: 15970
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetCollectionWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E63 RID: 15971 RVA: 0x0005B190 File Offset: 0x00059390
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003E64 RID: 15972
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E65 RID: 15973 RVA: 0x0005B1AC File Offset: 0x000593AC
		public new vtkXMLPartitionedDataSetCollectionWriter NewInstance()
		{
			vtkXMLPartitionedDataSetCollectionWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetCollectionWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E66 RID: 15974
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E67 RID: 15975 RVA: 0x0005B208 File Offset: 0x00059408
		public new static vtkXMLPartitionedDataSetCollectionWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPartitionedDataSetCollectionWriter vtkXMLPartitionedDataSetCollectionWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPartitionedDataSetCollectionWriter = (vtkXMLPartitionedDataSetCollectionWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPartitionedDataSetCollectionWriter.Register(null);
				}
			}
			return vtkXMLPartitionedDataSetCollectionWriter;
		}

		// Token: 0x06003E68 RID: 15976
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPartitionedDataSetCollectionWriter_SetInputData_09(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Primarily for backwards compatibility. `SetInputDataObject` is the
		/// preferred API to use to set input.
		/// </summary>
		// Token: 0x06003E69 RID: 15977 RVA: 0x0005B288 File Offset: 0x00059488
		public void SetInputData(vtkPartitionedDataSetCollection pd)
		{
			vtkXMLPartitionedDataSetCollectionWriter.vtkXMLPartitionedDataSetCollectionWriter_SetInputData_09(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BE RID: 1726
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPartitionedDataSetCollectionWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BF RID: 1727
		public new static readonly string MRClassNameKey = "class vtkXMLPartitionedDataSetCollectionWriter";
	}
}
