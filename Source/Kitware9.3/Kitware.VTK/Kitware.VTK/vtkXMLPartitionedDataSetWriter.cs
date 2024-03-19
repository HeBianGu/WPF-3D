using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLPartitionedDataSetWriter
	/// </summary>
	/// <remarks>
	///  XML writer for vtkPartitionedDataSet
	///
	/// vtkXMLPartitionedDataSetWriter is a writer for vtkPartitionedDataSet.
	/// vtkXMLPartitionedDataSetWriter supports distributed use-cases. Use
	/// `SetController` to set the controller to use in case of distributed
	/// execution. In that case, the meta-file is only written out on the root node.
	/// </remarks>
	// Token: 0x0200013E RID: 318
	public class vtkXMLPartitionedDataSetWriter : vtkXMLWriter2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003E6A RID: 15978 RVA: 0x0005B2B7 File Offset: 0x000594B7
		static vtkXMLPartitionedDataSetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPartitionedDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPartitionedDataSetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003E6B RID: 15979 RVA: 0x0005B2DF File Offset: 0x000594DF
		public vtkXMLPartitionedDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003E6C RID: 15980
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E6D RID: 15981 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public new static vtkXMLPartitionedDataSetWriter New()
		{
			vtkXMLPartitionedDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E6E RID: 15982 RVA: 0x0005B344 File Offset: 0x00059544
		public vtkXMLPartitionedDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003E6F RID: 15983 RVA: 0x0005B388 File Offset: 0x00059588
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003E70 RID: 15984
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003E71 RID: 15985 RVA: 0x0005B394 File Offset: 0x00059594
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003E72 RID: 15986
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E73 RID: 15987 RVA: 0x0005B3D0 File Offset: 0x000595D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003E74 RID: 15988
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E75 RID: 15989 RVA: 0x0005B3F0 File Offset: 0x000595F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003E76 RID: 15990
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E77 RID: 15991 RVA: 0x0005B40C File Offset: 0x0005960C
		public override int IsA(string type)
		{
			return vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003E78 RID: 15992
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E79 RID: 15993 RVA: 0x0005B42C File Offset: 0x0005962C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003E7A RID: 15994
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E7B RID: 15995 RVA: 0x0005B448 File Offset: 0x00059648
		public new vtkXMLPartitionedDataSetWriter NewInstance()
		{
			vtkXMLPartitionedDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E7C RID: 15996
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E7D RID: 15997 RVA: 0x0005B4A4 File Offset: 0x000596A4
		public new static vtkXMLPartitionedDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPartitionedDataSetWriter vtkXMLPartitionedDataSetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPartitionedDataSetWriter = (vtkXMLPartitionedDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPartitionedDataSetWriter.Register(null);
				}
			}
			return vtkXMLPartitionedDataSetWriter;
		}

		// Token: 0x06003E7E RID: 15998
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPartitionedDataSetWriter_SetInputData_09(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Primarily for backwards compatibility. `SetInputDataObject` is the
		/// preferred API to use to set input.
		/// </summary>
		// Token: 0x06003E7F RID: 15999 RVA: 0x0005B524 File Offset: 0x00059724
		public void SetInputData(vtkPartitionedDataSet pd)
		{
			vtkXMLPartitionedDataSetWriter.vtkXMLPartitionedDataSetWriter_SetInputData_09(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C0 RID: 1728
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPartitionedDataSetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C1 RID: 1729
		public new static readonly string MRClassNameKey = "class vtkXMLPartitionedDataSetWriter";
	}
}
