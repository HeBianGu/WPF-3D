using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSampleFunction
	/// </summary>
	/// <remarks>
	///    sample an implicit function over a structured point set
	///
	/// vtkSampleFunction is a source object that evaluates an implicit function
	/// and normals at each point in a vtkStructuredPoints. The user can specify
	/// the sample dimensions and location in space to perform the sampling. To
	/// create closed surfaces (in conjunction with the vtkContourFilter), capping
	/// can be turned on to set a particular value on the boundaries of the sample
	/// space.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitModeller
	/// </seealso>
	// Token: 0x020003E7 RID: 999
	public class vtkSampleFunction : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BF5D RID: 48989 RVA: 0x0010AB35 File Offset: 0x00108D35
		static vtkSampleFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSampleFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSampleFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF5E RID: 48990 RVA: 0x0010AB5D File Offset: 0x00108D5D
		public vtkSampleFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BF5F RID: 48991
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
		/// Capping turned off, and normal generation on.
		/// </summary>
		// Token: 0x0600BF60 RID: 48992 RVA: 0x0010AB6C File Offset: 0x00108D6C
		public new static vtkSampleFunction New()
		{
			vtkSampleFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
		/// Capping turned off, and normal generation on.
		/// </summary>
		// Token: 0x0600BF61 RID: 48993 RVA: 0x0010ABC0 File Offset: 0x00108DC0
		public vtkSampleFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSampleFunction.vtkSampleFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF62 RID: 48994 RVA: 0x0010AC04 File Offset: 0x00108E04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BF63 RID: 48995
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off capping. If capping is on, then the outer boundaries of the
		/// structured point set are set to cap value. This can be used to ensure
		/// surfaces are closed.
		/// </summary>
		// Token: 0x0600BF64 RID: 48996 RVA: 0x0010AC0F File Offset: 0x00108E0F
		public virtual void CappingOff()
		{
			vtkSampleFunction.vtkSampleFunction_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x0600BF65 RID: 48997
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off capping. If capping is on, then the outer boundaries of the
		/// structured point set are set to cap value. This can be used to ensure
		/// surfaces are closed.
		/// </summary>
		// Token: 0x0600BF66 RID: 48998 RVA: 0x0010AC1E File Offset: 0x00108E1E
		public virtual void CappingOn()
		{
			vtkSampleFunction.vtkSampleFunction_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0600BF67 RID: 48999
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of normals (normals are float values).
		/// </summary>
		// Token: 0x0600BF68 RID: 49000 RVA: 0x0010AC2D File Offset: 0x00108E2D
		public virtual void ComputeNormalsOff()
		{
			vtkSampleFunction.vtkSampleFunction_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0600BF69 RID: 49001
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of normals (normals are float values).
		/// </summary>
		// Token: 0x0600BF6A RID: 49002 RVA: 0x0010AC3C File Offset: 0x00108E3C
		public virtual void ComputeNormalsOn()
		{
			vtkSampleFunction.vtkSampleFunction_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0600BF6B RID: 49003
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSampleFunction_GetCapValue_05(HandleRef pThis);

		/// <summary>
		/// Set the cap value.
		/// </summary>
		// Token: 0x0600BF6C RID: 49004 RVA: 0x0010AC4C File Offset: 0x00108E4C
		public virtual double GetCapValue()
		{
			return vtkSampleFunction.vtkSampleFunction_GetCapValue_05(base.GetCppThis());
		}

		// Token: 0x0600BF6D RID: 49005
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleFunction_GetCapping_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off capping. If capping is on, then the outer boundaries of the
		/// structured point set are set to cap value. This can be used to ensure
		/// surfaces are closed.
		/// </summary>
		// Token: 0x0600BF6E RID: 49006 RVA: 0x0010AC6C File Offset: 0x00108E6C
		public virtual int GetCapping()
		{
			return vtkSampleFunction.vtkSampleFunction_GetCapping_06(base.GetCppThis());
		}

		// Token: 0x0600BF6F RID: 49007
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleFunction_GetComputeNormals_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of normals (normals are float values).
		/// </summary>
		// Token: 0x0600BF70 RID: 49008 RVA: 0x0010AC8C File Offset: 0x00108E8C
		public virtual int GetComputeNormals()
		{
			return vtkSampleFunction.vtkSampleFunction_GetComputeNormals_07(base.GetCppThis());
		}

		// Token: 0x0600BF71 RID: 49009
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_GetImplicitFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to use to generate data.
		/// </summary>
		// Token: 0x0600BF72 RID: 49010 RVA: 0x0010ACAC File Offset: 0x00108EAC
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetImplicitFunction_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0600BF73 RID: 49011
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSampleFunction_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the implicit function.
		/// </summary>
		// Token: 0x0600BF74 RID: 49012 RVA: 0x0010AD1C File Offset: 0x00108F1C
		public override ulong GetMTime()
		{
			return vtkSampleFunction.vtkSampleFunction_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0600BF75 RID: 49013
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_GetModelBounds_10(HandleRef pThis);

		/// <summary>
		/// Specify the region in space over which the sampling occurs. The
		/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
		/// </summary>
		// Token: 0x0600BF76 RID: 49014 RVA: 0x0010AD3C File Offset: 0x00108F3C
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetModelBounds_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BF77 RID: 49015
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_GetModelBounds_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the region in space over which the sampling occurs. The
		/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
		/// </summary>
		// Token: 0x0600BF78 RID: 49016 RVA: 0x0010AD84 File Offset: 0x00108F84
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkSampleFunction.vtkSampleFunction_GetModelBounds_11(base.GetCppThis(), data);
		}

		// Token: 0x0600BF79 RID: 49017
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_GetNormalArrayName_12(HandleRef pThis);

		/// <summary>
		/// Set/get the normal array name for this data set. Initial value is
		/// "normals".
		/// </summary>
		// Token: 0x0600BF7A RID: 49018 RVA: 0x0010AD94 File Offset: 0x00108F94
		public virtual string GetNormalArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSampleFunction.vtkSampleFunction_GetNormalArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BF7B RID: 49019
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSampleFunction_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF7C RID: 49020 RVA: 0x0010ADD0 File Offset: 0x00108FD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600BF7D RID: 49021
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSampleFunction_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF7E RID: 49022 RVA: 0x0010ADF0 File Offset: 0x00108FF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600BF7F RID: 49023
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleFunction_GetOutputScalarType_15(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BF80 RID: 49024 RVA: 0x0010AE0C File Offset: 0x0010900C
		public virtual int GetOutputScalarType()
		{
			return vtkSampleFunction.vtkSampleFunction_GetOutputScalarType_15(base.GetCppThis());
		}

		// Token: 0x0600BF81 RID: 49025
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_GetSampleDimensions_16(HandleRef pThis);

		/// <summary>
		/// Specify the dimensions of the data on which to sample.
		/// </summary>
		// Token: 0x0600BF82 RID: 49026 RVA: 0x0010AE2C File Offset: 0x0010902C
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_GetSampleDimensions_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BF83 RID: 49027
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_GetSampleDimensions_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the dimensions of the data on which to sample.
		/// </summary>
		// Token: 0x0600BF84 RID: 49028 RVA: 0x0010AE74 File Offset: 0x00109074
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkSampleFunction.vtkSampleFunction_GetSampleDimensions_17(base.GetCppThis(), data);
		}

		// Token: 0x0600BF85 RID: 49029
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_GetScalarArrayName_18(HandleRef pThis);

		/// <summary>
		/// Set/get the scalar array name for this data set. Initial value is
		/// "scalars".
		/// </summary>
		// Token: 0x0600BF86 RID: 49030 RVA: 0x0010AE84 File Offset: 0x00109084
		public virtual string GetScalarArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSampleFunction.vtkSampleFunction_GetScalarArrayName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BF87 RID: 49031
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleFunction_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF88 RID: 49032 RVA: 0x0010AEC0 File Offset: 0x001090C0
		public override int IsA(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600BF89 RID: 49033
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSampleFunction_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF8A RID: 49034 RVA: 0x0010AEE0 File Offset: 0x001090E0
		public new static int IsTypeOf(string type)
		{
			return vtkSampleFunction.vtkSampleFunction_IsTypeOf_20(type);
		}

		// Token: 0x0600BF8B RID: 49035
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF8C RID: 49036 RVA: 0x0010AEFC File Offset: 0x001090FC
		public new vtkSampleFunction NewInstance()
		{
			vtkSampleFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BF8D RID: 49037
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSampleFunction_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF8E RID: 49038 RVA: 0x0010AF58 File Offset: 0x00109158
		public new static vtkSampleFunction SafeDownCast(vtkObjectBase o)
		{
			vtkSampleFunction vtkSampleFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSampleFunction.vtkSampleFunction_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSampleFunction = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSampleFunction.Register(null);
				}
			}
			return vtkSampleFunction;
		}

		// Token: 0x0600BF8F RID: 49039
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetCapValue_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the cap value.
		/// </summary>
		// Token: 0x0600BF90 RID: 49040 RVA: 0x0010AFD7 File Offset: 0x001091D7
		public virtual void SetCapValue(double _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetCapValue_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF91 RID: 49041
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetCapping_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off capping. If capping is on, then the outer boundaries of the
		/// structured point set are set to cap value. This can be used to ensure
		/// surfaces are closed.
		/// </summary>
		// Token: 0x0600BF92 RID: 49042 RVA: 0x0010AFE7 File Offset: 0x001091E7
		public virtual void SetCapping(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetCapping_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF93 RID: 49043
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetComputeNormals_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of normals (normals are float values).
		/// </summary>
		// Token: 0x0600BF94 RID: 49044 RVA: 0x0010AFF7 File Offset: 0x001091F7
		public virtual void SetComputeNormals(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetComputeNormals_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF95 RID: 49045
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetImplicitFunction_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to use to generate data.
		/// </summary>
		// Token: 0x0600BF96 RID: 49046 RVA: 0x0010B008 File Offset: 0x00109208
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkSampleFunction.vtkSampleFunction_SetImplicitFunction_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BF97 RID: 49047
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetModelBounds_28(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Specify the region in space over which the sampling occurs. The
		/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
		/// </summary>
		// Token: 0x0600BF98 RID: 49048 RVA: 0x0010B037 File Offset: 0x00109237
		public void SetModelBounds(IntPtr bounds)
		{
			vtkSampleFunction.vtkSampleFunction_SetModelBounds_28(base.GetCppThis(), bounds);
		}

		// Token: 0x0600BF99 RID: 49049
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetModelBounds_29(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Specify the region in space over which the sampling occurs. The
		/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
		/// </summary>
		// Token: 0x0600BF9A RID: 49050 RVA: 0x0010B047 File Offset: 0x00109247
		public void SetModelBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkSampleFunction.vtkSampleFunction_SetModelBounds_29(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0600BF9B RID: 49051
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetNormalArrayName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the normal array name for this data set. Initial value is
		/// "normals".
		/// </summary>
		// Token: 0x0600BF9C RID: 49052 RVA: 0x0010B05F File Offset: 0x0010925F
		public virtual void SetNormalArrayName(string _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetNormalArrayName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF9D RID: 49053
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarType_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BF9E RID: 49054 RVA: 0x0010B06F File Offset: 0x0010926F
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarType_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF9F RID: 49055
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToChar_32(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFA0 RID: 49056 RVA: 0x0010B07F File Offset: 0x0010927F
		public void SetOutputScalarTypeToChar()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToChar_32(base.GetCppThis());
		}

		// Token: 0x0600BFA1 RID: 49057
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToDouble_33(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFA2 RID: 49058 RVA: 0x0010B08E File Offset: 0x0010928E
		public void SetOutputScalarTypeToDouble()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToDouble_33(base.GetCppThis());
		}

		// Token: 0x0600BFA3 RID: 49059
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToFloat_34(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFA4 RID: 49060 RVA: 0x0010B09D File Offset: 0x0010929D
		public void SetOutputScalarTypeToFloat()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToFloat_34(base.GetCppThis());
		}

		// Token: 0x0600BFA5 RID: 49061
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToInt_35(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFA6 RID: 49062 RVA: 0x0010B0AC File Offset: 0x001092AC
		public void SetOutputScalarTypeToInt()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToInt_35(base.GetCppThis());
		}

		// Token: 0x0600BFA7 RID: 49063
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToLong_36(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFA8 RID: 49064 RVA: 0x0010B0BB File Offset: 0x001092BB
		public void SetOutputScalarTypeToLong()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToLong_36(base.GetCppThis());
		}

		// Token: 0x0600BFA9 RID: 49065
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToShort_37(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFAA RID: 49066 RVA: 0x0010B0CA File Offset: 0x001092CA
		public void SetOutputScalarTypeToShort()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToShort_37(base.GetCppThis());
		}

		// Token: 0x0600BFAB RID: 49067
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_38(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFAC RID: 49068 RVA: 0x0010B0D9 File Offset: 0x001092D9
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_38(base.GetCppThis());
		}

		// Token: 0x0600BFAD RID: 49069
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_39(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFAE RID: 49070 RVA: 0x0010B0E8 File Offset: 0x001092E8
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_39(base.GetCppThis());
		}

		// Token: 0x0600BFAF RID: 49071
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_40(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFB0 RID: 49072 RVA: 0x0010B0F7 File Offset: 0x001092F7
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_40(base.GetCppThis());
		}

		// Token: 0x0600BFB1 RID: 49073
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_41(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x0600BFB2 RID: 49074 RVA: 0x0010B106 File Offset: 0x00109306
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkSampleFunction.vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_41(base.GetCppThis());
		}

		// Token: 0x0600BFB3 RID: 49075
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetSampleDimensions_42(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Specify the dimensions of the data on which to sample.
		/// </summary>
		// Token: 0x0600BFB4 RID: 49076 RVA: 0x0010B115 File Offset: 0x00109315
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkSampleFunction.vtkSampleFunction_SetSampleDimensions_42(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600BFB5 RID: 49077
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetSampleDimensions_43(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Specify the dimensions of the data on which to sample.
		/// </summary>
		// Token: 0x0600BFB6 RID: 49078 RVA: 0x0010B127 File Offset: 0x00109327
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkSampleFunction.vtkSampleFunction_SetSampleDimensions_43(base.GetCppThis(), dim);
		}

		// Token: 0x0600BFB7 RID: 49079
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSampleFunction_SetScalarArrayName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the scalar array name for this data set. Initial value is
		/// "scalars".
		/// </summary>
		// Token: 0x0600BFB8 RID: 49080 RVA: 0x0010B137 File Offset: 0x00109337
		public virtual void SetScalarArrayName(string _arg)
		{
			vtkSampleFunction.vtkSampleFunction_SetScalarArrayName_44(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3B RID: 3643
		public new const string MRFullTypeName = "Kitware.VTK.vtkSampleFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3C RID: 3644
		public new static readonly string MRClassNameKey = "class vtkSampleFunction";
	}
}
