using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleReader
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that are not time or parallel aware
	///
	/// </remarks>
	// Token: 0x02000191 RID: 401
	public abstract class vtkSimpleReader : vtkReaderAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004E4C RID: 20044 RVA: 0x00071D4B File Offset: 0x0006FF4B
		static vtkSimpleReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004E4D RID: 20045 RVA: 0x00071D73 File Offset: 0x0006FF73
		public vtkSimpleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004E4E RID: 20046 RVA: 0x00071D81 File Offset: 0x0006FF81
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004E4F RID: 20047
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleReader_AddFileName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Add a filename to be read. Since this superclass handles
		/// file series to support time, multiple filenames can be added.
		/// Note that the time values are either integers growing sequentially,
		/// or are obtained from individual files as supported by the subclass.
		/// </summary>
		// Token: 0x06004E50 RID: 20048 RVA: 0x00071D8C File Offset: 0x0006FF8C
		public void AddFileName(string fname)
		{
			vtkSimpleReader.vtkSimpleReader_AddFileName_01(base.GetCppThis(), fname);
		}

		// Token: 0x06004E51 RID: 20049
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleReader_ClearFileNames_02(HandleRef pThis);

		/// <summary>
		/// Removes all filenames stored by the reader.
		/// </summary>
		// Token: 0x06004E52 RID: 20050 RVA: 0x00071D9C File Offset: 0x0006FF9C
		public void ClearFileNames()
		{
			vtkSimpleReader.vtkSimpleReader_ClearFileNames_02(base.GetCppThis());
		}

		// Token: 0x06004E53 RID: 20051
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleReader_GetCurrentFileName_03(HandleRef pThis);

		/// <summary>
		/// Returns the filename that was last loaded by the reader.
		/// This is set internally in ReadMesh()
		/// </summary>
		// Token: 0x06004E54 RID: 20052 RVA: 0x00071DAC File Offset: 0x0006FFAC
		public string GetCurrentFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSimpleReader.vtkSimpleReader_GetCurrentFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E55 RID: 20053
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleReader_GetFileName_04(HandleRef pThis, int i);

		/// <summary>
		/// Returns a particular filename stored by the reader.
		/// </summary>
		// Token: 0x06004E56 RID: 20054 RVA: 0x00071DE8 File Offset: 0x0006FFE8
		public string GetFileName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkSimpleReader.vtkSimpleReader_GetFileName_04(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004E57 RID: 20055
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_GetNumberOfFileNames_05(HandleRef pThis);

		/// <summary>
		/// Returns the number of filenames stored by the reader.
		/// </summary>
		// Token: 0x06004E58 RID: 20056 RVA: 0x00071E24 File Offset: 0x00070024
		public int GetNumberOfFileNames()
		{
			return vtkSimpleReader.vtkSimpleReader_GetNumberOfFileNames_05(base.GetCppThis());
		}

		// Token: 0x06004E59 RID: 20057
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E5A RID: 20058 RVA: 0x00071E44 File Offset: 0x00070044
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleReader.vtkSimpleReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004E5B RID: 20059
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E5C RID: 20060 RVA: 0x00071E64 File Offset: 0x00070064
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleReader.vtkSimpleReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004E5D RID: 20061
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimpleReader_GetTimeValue_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// A subclass can override this method to provide an actual
		/// time value for a given file (this method is called for
		/// each filename stored by the reader). If time values is not
		/// available, the subclass does not have to override. This
		/// will return vtkMath::NaN() if no time value is present
		/// in the file.
		/// </summary>
		// Token: 0x06004E5E RID: 20062 RVA: 0x00071E80 File Offset: 0x00070080
		public virtual double GetTimeValue(string fname)
		{
			return vtkSimpleReader.vtkSimpleReader_GetTimeValue_08(base.GetCppThis(), fname);
		}

		// Token: 0x06004E5F RID: 20063
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E60 RID: 20064 RVA: 0x00071EA0 File Offset: 0x000700A0
		public override int IsA(string type)
		{
			return vtkSimpleReader.vtkSimpleReader_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06004E61 RID: 20065
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E62 RID: 20066 RVA: 0x00071EC0 File Offset: 0x000700C0
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleReader.vtkSimpleReader_IsTypeOf_10(type);
		}

		// Token: 0x06004E63 RID: 20067
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E64 RID: 20068 RVA: 0x00071EDC File Offset: 0x000700DC
		public new vtkSimpleReader NewInstance()
		{
			vtkSimpleReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleReader.vtkSimpleReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004E65 RID: 20069
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadArrays_12(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x06004E66 RID: 20070 RVA: 0x00071F38 File Offset: 0x00070138
		public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadArrays_12(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E67 RID: 20071
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadArraysSimple_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// A method that needs to be override by the subclass to provide
		/// data arrays. Note that the filename is passed to this
		/// method and should be used by the subclass. The subclass directly
		/// adds data arrays to the provided data object.
		/// </summary>
		// Token: 0x06004E68 RID: 20072 RVA: 0x00071F74 File Offset: 0x00070174
		public virtual int ReadArraysSimple(string fname, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadArraysSimple_13(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E69 RID: 20073
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadMesh_14(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x06004E6A RID: 20074 RVA: 0x00071FAC File Offset: 0x000701AC
		public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadMesh_14(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E6B RID: 20075
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadMeshSimple_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// A method that needs to be override by the subclass to provide
		/// the mesh (topology). Note that the filename is passed to this
		/// method and should be used by the subclass. The subclass directly
		/// adds the structure/topology to the provided data object.
		/// </summary>
		// Token: 0x06004E6C RID: 20076 RVA: 0x00071FE8 File Offset: 0x000701E8
		public virtual int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadMeshSimple_15(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E6D RID: 20077
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadMetaData_16(HandleRef pThis, HandleRef metadata);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x06004E6E RID: 20078 RVA: 0x00072020 File Offset: 0x00070220
		public override int ReadMetaData(vtkInformation metadata)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadMetaData_16(base.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06004E6F RID: 20079
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadMetaDataSimple_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// A subclass can override this method to provide meta data
		/// specific to a particular file. In order for this method
		/// to be called, HasTemporalMetaData has to be set to true.
		/// </summary>
		// Token: 0x06004E70 RID: 20080 RVA: 0x00072054 File Offset: 0x00070254
		public virtual int ReadMetaDataSimple(string arg0, vtkInformation arg1)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadMetaDataSimple_17(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004E71 RID: 20081
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadPoints_18(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x06004E72 RID: 20082 RVA: 0x0007208C File Offset: 0x0007028C
		public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadPoints_18(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E73 RID: 20083
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadPointsSimple_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// A method that needs to be override by the subclass to provide
		/// the point coordinates. Note that the filename is passed to this
		/// method and should be used by the subclass. The subclass directly
		/// adds the coordinates to the provided data object.
		/// </summary>
		// Token: 0x06004E74 RID: 20084 RVA: 0x000720C8 File Offset: 0x000702C8
		public virtual int ReadPointsSimple(string fname, vtkDataObject output)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadPointsSimple_19(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004E75 RID: 20085
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleReader_ReadTimeDependentMetaData_20(HandleRef pThis, int timestep, HandleRef metadata);

		/// <summary>
		/// This is the superclass API overridden by this class
		/// to provide time support internally. Subclasses should
		/// not normally have to override these methods.
		/// </summary>
		// Token: 0x06004E76 RID: 20086 RVA: 0x00072100 File Offset: 0x00070300
		public override int ReadTimeDependentMetaData(int timestep, vtkInformation metadata)
		{
			return vtkSimpleReader.vtkSimpleReader_ReadTimeDependentMetaData_20(base.GetCppThis(), timestep, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06004E77 RID: 20087
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E78 RID: 20088 RVA: 0x00072138 File Offset: 0x00070338
		public new static vtkSimpleReader SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleReader vtkSimpleReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleReader.vtkSimpleReader_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleReader = (vtkSimpleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleReader.Register(null);
				}
			}
			return vtkSimpleReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000783 RID: 1923
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000784 RID: 1924
		public new static readonly string MRClassNameKey = "class vtkSimpleReader";
	}
}
