using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReaderAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for readers that implement a simplified API.
	///
	/// This class and associated subclasses were created to make it easier to
	/// develop readers. When directly subclassing from other algorithm classes
	/// one has to learn a general purpose API that somewhat obfuscates pipeline
	/// functionality behind information keys. One has to know how to find
	/// time and pieces requests using keys for example. Furthermore, these
	/// classes together with specialized executives can implement common
	/// reader functionality for things such as file series (for time and/or
	/// partitions), caching, mapping time requests to indices etc.
	/// This class implements the most basic API which is specialized as
	/// needed by subclasses (for file series for example).
	/// </remarks>
	// Token: 0x02000152 RID: 338
	public abstract class vtkReaderAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004068 RID: 16488 RVA: 0x0005E983 File Offset: 0x0005CB83
		static vtkReaderAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReaderAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReaderAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004069 RID: 16489 RVA: 0x0005E9AB File Offset: 0x0005CBAB
		public vtkReaderAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600406A RID: 16490 RVA: 0x0005E9B9 File Offset: 0x0005CBB9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600406B RID: 16491
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReaderAlgorithm_CreateOutput_01(HandleRef pThis, HandleRef currentOutput, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This can be overridden by a subclass to create an output that
		/// is determined by the file being read. If the output is known at
		/// compile time, it is easier to override FillOutputPortInformation()
		/// to set vtkDataObject::DATA_TYPE_NAME(). The subclass should compare
		/// the new output type with the type of the currentOutput argument and
		/// return currentOutput without changing its reference count if the
		/// types are same.
		/// </summary>
		// Token: 0x0600406C RID: 16492 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
		public virtual vtkDataObject CreateOutput(vtkDataObject currentOutput)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReaderAlgorithm.vtkReaderAlgorithm_CreateOutput_01(base.GetCppThis(), (currentOutput == null) ? default(HandleRef) : currentOutput.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600406D RID: 16493
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReaderAlgorithm_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600406E RID: 16494 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600406F RID: 16495
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReaderAlgorithm_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004070 RID: 16496 RVA: 0x0005EA6C File Offset: 0x0005CC6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06004071 RID: 16497
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004072 RID: 16498 RVA: 0x0005EA88 File Offset: 0x0005CC88
		public override int IsA(string type)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06004073 RID: 16499
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004074 RID: 16500 RVA: 0x0005EAA8 File Offset: 0x0005CCA8
		public new static int IsTypeOf(string type)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_IsTypeOf_05(type);
		}

		// Token: 0x06004075 RID: 16501
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReaderAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004076 RID: 16502 RVA: 0x0005EAC4 File Offset: 0x0005CCC4
		public new vtkReaderAlgorithm NewInstance()
		{
			vtkReaderAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReaderAlgorithm.vtkReaderAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReaderAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004077 RID: 16503
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_ReadArrays_07(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// Read all the arrays (point, cell, field etc.). This is called after
		/// ReadPoints() so the data object should already contain the mesh and
		/// points.
		/// </summary>
		// Token: 0x06004078 RID: 16504 RVA: 0x0005EB20 File Offset: 0x0005CD20
		public virtual int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_ReadArrays_07(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004079 RID: 16505
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_ReadMesh_08(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// Read the mesh (connectivity) for a given set of data partitioning,
		/// number of ghost levels and time step (index). The reader populates
		/// the data object passed in as the last argument. It is OK to read
		/// more than the mesh (points, arrays etc.). However, this may interfere
		/// with any caching implemented by the executive (i.e. cause more reads).
		/// </summary>
		// Token: 0x0600407A RID: 16506 RVA: 0x0005EB5C File Offset: 0x0005CD5C
		public virtual int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_ReadMesh_08(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600407B RID: 16507
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_ReadMetaData_09(HandleRef pThis, HandleRef metadata);

		/// <summary>
		/// Provide meta-data for the pipeline. This meta-data cannot vary over
		/// time as this method will not be called when only a request is changed.
		/// These include things like time steps. Subclasses may have specialized
		/// interfaces making this simpler.
		/// </summary>
		// Token: 0x0600407C RID: 16508 RVA: 0x0005EB98 File Offset: 0x0005CD98
		public virtual int ReadMetaData(vtkInformation metadata)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_ReadMetaData_09(base.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x0600407D RID: 16509
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_ReadPoints_10(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// Read the points. The reader populates the input data object. This is
		/// called after ReadMesh() so the data object should already contain the
		/// mesh.
		/// </summary>
		// Token: 0x0600407E RID: 16510 RVA: 0x0005EBCC File Offset: 0x0005CDCC
		public virtual int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_ReadPoints_10(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600407F RID: 16511
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReaderAlgorithm_ReadTimeDependentMetaData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Provide meta-data for the pipeline. This meta-data can vary over time
		/// as this method will be called after a request is changed (such as time)
		/// These include things like whole extent. Subclasses may have specialized
		/// interfaces making this simpler.
		/// </summary>
		// Token: 0x06004080 RID: 16512 RVA: 0x0005EC08 File Offset: 0x0005CE08
		public virtual int ReadTimeDependentMetaData(int arg0, vtkInformation arg1)
		{
			return vtkReaderAlgorithm.vtkReaderAlgorithm_ReadTimeDependentMetaData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004081 RID: 16513
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReaderAlgorithm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004082 RID: 16514 RVA: 0x0005EC40 File Offset: 0x0005CE40
		public new static vtkReaderAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkReaderAlgorithm vtkReaderAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReaderAlgorithm.vtkReaderAlgorithm_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReaderAlgorithm = (vtkReaderAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReaderAlgorithm.Register(null);
				}
			}
			return vtkReaderAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E8 RID: 1768
		public new const string MRFullTypeName = "Kitware.VTK.vtkReaderAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E9 RID: 1769
		public new static readonly string MRClassNameKey = "class vtkReaderAlgorithm";
	}
}
