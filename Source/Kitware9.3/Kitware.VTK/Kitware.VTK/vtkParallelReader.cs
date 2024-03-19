using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelReader
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that are parallel aware
	///
	/// vtkParallelReader is a vtkReaderAlgorithm subclass that provides
	/// a specialized API to develop readers that are parallel aware (i.e.
	/// can handle piece requests) but do not natively support time series.
	/// This reader adds support for file series in order to support time
	/// series.
	/// </remarks>
	// Token: 0x02000153 RID: 339
	public abstract class vtkParallelReader : vtkReaderAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004083 RID: 16515 RVA: 0x0005ECBF File Offset: 0x0005CEBF
		static vtkParallelReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004084 RID: 16516 RVA: 0x0005ECE7 File Offset: 0x0005CEE7
		public vtkParallelReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004085 RID: 16517 RVA: 0x0005ECF5 File Offset: 0x0005CEF5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004086 RID: 16518
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelReader_AddFileName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Add a filename to be read. Since this superclass handles
		/// file series to support time, multiple filenames can be added.
		/// Note that the time values are either integers growing sequentially,
		/// or are obtained from individual files as supported by the subclass.
		/// </summary>
		// Token: 0x06004087 RID: 16519 RVA: 0x0005ED00 File Offset: 0x0005CF00
		public void AddFileName(string fname)
		{
			vtkParallelReader.vtkParallelReader_AddFileName_01(base.GetCppThis(), fname);
		}

		// Token: 0x06004088 RID: 16520
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelReader_ClearFileNames_02(HandleRef pThis);

		/// <summary>
		/// Removes all filenames stored by the reader.
		/// </summary>
		// Token: 0x06004089 RID: 16521 RVA: 0x0005ED10 File Offset: 0x0005CF10
		public void ClearFileNames()
		{
			vtkParallelReader.vtkParallelReader_ClearFileNames_02(base.GetCppThis());
		}

		// Token: 0x0600408A RID: 16522
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelReader_GetCurrentFileName_03(HandleRef pThis);

		/// <summary>
		/// Returns the filename that was last loaded by the reader.
		/// This is set internally in ReadMesh()
		/// </summary>
		// Token: 0x0600408B RID: 16523 RVA: 0x0005ED20 File Offset: 0x0005CF20
		public string GetCurrentFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelReader.vtkParallelReader_GetCurrentFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600408C RID: 16524
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelReader_GetFileName_04(HandleRef pThis, int i);

		/// <summary>
		/// Returns a particular filename stored by the reader.
		/// </summary>
		// Token: 0x0600408D RID: 16525 RVA: 0x0005ED5C File Offset: 0x0005CF5C
		public string GetFileName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelReader.vtkParallelReader_GetFileName_04(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600408E RID: 16526
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_GetNumberOfFileNames_05(HandleRef pThis);

		/// <summary>
		/// Returns the number of filenames stored by the reader.
		/// </summary>
		// Token: 0x0600408F RID: 16527 RVA: 0x0005ED98 File Offset: 0x0005CF98
		public int GetNumberOfFileNames()
		{
			return vtkParallelReader.vtkParallelReader_GetNumberOfFileNames_05(base.GetCppThis());
		}

		// Token: 0x06004090 RID: 16528
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004091 RID: 16529 RVA: 0x0005EDB8 File Offset: 0x0005CFB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelReader.vtkParallelReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004092 RID: 16530
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004093 RID: 16531 RVA: 0x0005EDD8 File Offset: 0x0005CFD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelReader.vtkParallelReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004094 RID: 16532
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004095 RID: 16533 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
		public override int IsA(string type)
		{
			return vtkParallelReader.vtkParallelReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06004096 RID: 16534
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004097 RID: 16535 RVA: 0x0005EE14 File Offset: 0x0005D014
		public new static int IsTypeOf(string type)
		{
			return vtkParallelReader.vtkParallelReader_IsTypeOf_09(type);
		}

		// Token: 0x06004098 RID: 16536
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004099 RID: 16537 RVA: 0x0005EE30 File Offset: 0x0005D030
		public new vtkParallelReader NewInstance()
		{
			vtkParallelReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelReader.vtkParallelReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600409A RID: 16538
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_ReadArrays_11(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x0600409B RID: 16539 RVA: 0x0005EE8C File Offset: 0x0005D08C
		public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkParallelReader.vtkParallelReader_ReadArrays_11(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600409C RID: 16540
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_ReadMesh_12(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x0600409D RID: 16541 RVA: 0x0005EEC8 File Offset: 0x0005D0C8
		public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkParallelReader.vtkParallelReader_ReadMesh_12(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600409E RID: 16542
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_ReadMetaData_13(HandleRef pThis, HandleRef metadata);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x0600409F RID: 16543 RVA: 0x0005EF04 File Offset: 0x0005D104
		public override int ReadMetaData(vtkInformation metadata)
		{
			return vtkParallelReader.vtkParallelReader_ReadMetaData_13(base.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x060040A0 RID: 16544
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelReader_ReadPoints_14(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x060040A1 RID: 16545 RVA: 0x0005EF38 File Offset: 0x0005D138
		public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkParallelReader.vtkParallelReader_ReadPoints_14(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x060040A2 RID: 16546
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060040A3 RID: 16547 RVA: 0x0005EF74 File Offset: 0x0005D174
		public new static vtkParallelReader SafeDownCast(vtkObjectBase o)
		{
			vtkParallelReader vtkParallelReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelReader.vtkParallelReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelReader = (vtkParallelReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelReader.Register(null);
				}
			}
			return vtkParallelReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006EA RID: 1770
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006EB RID: 1771
		public new static readonly string MRClassNameKey = "class vtkParallelReader";
	}
}
