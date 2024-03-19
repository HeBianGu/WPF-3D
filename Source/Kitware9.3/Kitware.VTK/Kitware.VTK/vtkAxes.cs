using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxes
	/// </summary>
	/// <remarks>
	///    create an x-y-z axes
	///
	/// vtkAxes creates three lines that form an x-y-z axes. The origin of the
	/// axes is user specified (0,0,0 is default), and the size is specified with
	/// a scale factor. Three scalar values are generated for the three lines and
	/// can be used (via color map) to indicate a particular coordinate axis.
	/// </remarks>
	// Token: 0x02000873 RID: 2163
	public class vtkAxes : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016734 RID: 91956 RVA: 0x001F91A3 File Offset: 0x001F73A3
		static vtkAxes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016735 RID: 91957 RVA: 0x001F91CB File Offset: 0x001F73CB
		public vtkAxes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016736 RID: 91958
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016737 RID: 91959 RVA: 0x001F91DC File Offset: 0x001F73DC
		public new static vtkAxes New()
		{
			vtkAxes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxes.vtkAxes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016738 RID: 91960 RVA: 0x001F9230 File Offset: 0x001F7430
		public vtkAxes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxes.vtkAxes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016739 RID: 91961 RVA: 0x001F9274 File Offset: 0x001F7474
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601673A RID: 91962
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_ComputeNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Option for computing normals.  By default they are computed.
		/// </summary>
		// Token: 0x0601673B RID: 91963 RVA: 0x001F927F File Offset: 0x001F747F
		public virtual void ComputeNormalsOff()
		{
			vtkAxes.vtkAxes_ComputeNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x0601673C RID: 91964
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_ComputeNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Option for computing normals.  By default they are computed.
		/// </summary>
		// Token: 0x0601673D RID: 91965 RVA: 0x001F928E File Offset: 0x001F748E
		public virtual void ComputeNormalsOn()
		{
			vtkAxes.vtkAxes_ComputeNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x0601673E RID: 91966
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxes_GetComputeNormals_03(HandleRef pThis);

		/// <summary>
		/// Option for computing normals.  By default they are computed.
		/// </summary>
		// Token: 0x0601673F RID: 91967 RVA: 0x001F92A0 File Offset: 0x001F74A0
		public virtual int GetComputeNormals()
		{
			return vtkAxes.vtkAxes_GetComputeNormals_03(base.GetCppThis());
		}

		// Token: 0x06016740 RID: 91968
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016741 RID: 91969 RVA: 0x001F92C0 File Offset: 0x001F74C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxes.vtkAxes_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06016742 RID: 91970
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxes_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016743 RID: 91971 RVA: 0x001F92E0 File Offset: 0x001F74E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxes.vtkAxes_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06016744 RID: 91972
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxes_GetOrigin_06(HandleRef pThis);

		/// <summary>
		/// Set the origin of the axes.
		/// </summary>
		// Token: 0x06016745 RID: 91973 RVA: 0x001F92FC File Offset: 0x001F74FC
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkAxes.vtkAxes_GetOrigin_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016746 RID: 91974
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_GetOrigin_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the origin of the axes.
		/// </summary>
		// Token: 0x06016747 RID: 91975 RVA: 0x001F9344 File Offset: 0x001F7544
		public virtual void GetOrigin(IntPtr data)
		{
			vtkAxes.vtkAxes_GetOrigin_07(base.GetCppThis(), data);
		}

		// Token: 0x06016748 RID: 91976
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxes_GetScaleFactor_08(HandleRef pThis);

		/// <summary>
		/// Set the scale factor of the axes. Used to control size.
		/// </summary>
		// Token: 0x06016749 RID: 91977 RVA: 0x001F9354 File Offset: 0x001F7554
		public virtual double GetScaleFactor()
		{
			return vtkAxes.vtkAxes_GetScaleFactor_08(base.GetCppThis());
		}

		// Token: 0x0601674A RID: 91978
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxes_GetSymmetric_09(HandleRef pThis);

		/// <summary>
		/// If Symmetric is on, the axis continue to negative values.
		/// </summary>
		// Token: 0x0601674B RID: 91979 RVA: 0x001F9374 File Offset: 0x001F7574
		public virtual int GetSymmetric()
		{
			return vtkAxes.vtkAxes_GetSymmetric_09(base.GetCppThis());
		}

		// Token: 0x0601674C RID: 91980
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxes_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601674D RID: 91981 RVA: 0x001F9394 File Offset: 0x001F7594
		public override int IsA(string type)
		{
			return vtkAxes.vtkAxes_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601674E RID: 91982
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxes_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601674F RID: 91983 RVA: 0x001F93B4 File Offset: 0x001F75B4
		public new static int IsTypeOf(string type)
		{
			return vtkAxes.vtkAxes_IsTypeOf_11(type);
		}

		// Token: 0x06016750 RID: 91984
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016751 RID: 91985 RVA: 0x001F93D0 File Offset: 0x001F75D0
		public new vtkAxes NewInstance()
		{
			vtkAxes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxes.vtkAxes_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016752 RID: 91986
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016753 RID: 91987 RVA: 0x001F942C File Offset: 0x001F762C
		public new static vtkAxes SafeDownCast(vtkObjectBase o)
		{
			vtkAxes vtkAxes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxes.vtkAxes_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxes = (vtkAxes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxes.Register(null);
				}
			}
			return vtkAxes;
		}

		// Token: 0x06016754 RID: 91988
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SetComputeNormals_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Option for computing normals.  By default they are computed.
		/// </summary>
		// Token: 0x06016755 RID: 91989 RVA: 0x001F94AB File Offset: 0x001F76AB
		public virtual void SetComputeNormals(int _arg)
		{
			vtkAxes.vtkAxes_SetComputeNormals_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06016756 RID: 91990
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SetOrigin_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the origin of the axes.
		/// </summary>
		// Token: 0x06016757 RID: 91991 RVA: 0x001F94BB File Offset: 0x001F76BB
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkAxes.vtkAxes_SetOrigin_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016758 RID: 91992
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SetOrigin_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the origin of the axes.
		/// </summary>
		// Token: 0x06016759 RID: 91993 RVA: 0x001F94CD File Offset: 0x001F76CD
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkAxes.vtkAxes_SetOrigin_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601675A RID: 91994
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SetScaleFactor_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the scale factor of the axes. Used to control size.
		/// </summary>
		// Token: 0x0601675B RID: 91995 RVA: 0x001F94DD File Offset: 0x001F76DD
		public virtual void SetScaleFactor(double _arg)
		{
			vtkAxes.vtkAxes_SetScaleFactor_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601675C RID: 91996
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SetSymmetric_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If Symmetric is on, the axis continue to negative values.
		/// </summary>
		// Token: 0x0601675D RID: 91997 RVA: 0x001F94ED File Offset: 0x001F76ED
		public virtual void SetSymmetric(int _arg)
		{
			vtkAxes.vtkAxes_SetSymmetric_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601675E RID: 91998
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SymmetricOff_20(HandleRef pThis);

		/// <summary>
		/// If Symmetric is on, the axis continue to negative values.
		/// </summary>
		// Token: 0x0601675F RID: 91999 RVA: 0x001F94FD File Offset: 0x001F76FD
		public virtual void SymmetricOff()
		{
			vtkAxes.vtkAxes_SymmetricOff_20(base.GetCppThis());
		}

		// Token: 0x06016760 RID: 92000
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxes_SymmetricOn_21(HandleRef pThis);

		/// <summary>
		/// If Symmetric is on, the axis continue to negative values.
		/// </summary>
		// Token: 0x06016761 RID: 92001 RVA: 0x001F950C File Offset: 0x001F770C
		public virtual void SymmetricOn()
		{
			vtkAxes.vtkAxes_SymmetricOn_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193C RID: 6460
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193D RID: 6461
		public new static readonly string MRClassNameKey = "class vtkAxes";
	}
}
