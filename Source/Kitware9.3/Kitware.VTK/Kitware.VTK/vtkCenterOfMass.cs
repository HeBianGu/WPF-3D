using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCenterOfMass
	/// </summary>
	/// <remarks>
	///    Find the center of mass of a set of points.
	///
	/// vtkCenterOfMass finds the "center of mass" of a vtkPointSet (vtkPolyData
	/// or vtkUnstructuredGrid). Optionally, the user can specify to use the scalars
	/// as weights in the computation. If this option, UseScalarsAsWeights, is off,
	/// each point contributes equally in the calculation.
	///
	/// You must ensure Update() has been called before GetCenter will produce a valid
	/// value.
	/// </remarks>
	// Token: 0x02000948 RID: 2376
	public class vtkCenterOfMass : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018A02 RID: 100866 RVA: 0x00226851 File Offset: 0x00224A51
		static vtkCenterOfMass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCenterOfMass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCenterOfMass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018A03 RID: 100867 RVA: 0x00226879 File Offset: 0x00224A79
		public vtkCenterOfMass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018A04 RID: 100868
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenterOfMass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A05 RID: 100869 RVA: 0x00226888 File Offset: 0x00224A88
		public new static vtkCenterOfMass New()
		{
			vtkCenterOfMass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenterOfMass.vtkCenterOfMass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A06 RID: 100870 RVA: 0x002268DC File Offset: 0x00224ADC
		public vtkCenterOfMass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCenterOfMass.vtkCenterOfMass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018A07 RID: 100871 RVA: 0x00226920 File Offset: 0x00224B20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018A08 RID: 100872
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_ComputeCenterOfMass_01(HandleRef input, HandleRef scalars, IntPtr center);

		/// <summary>
		/// This function is called by RequestData. It exists so that
		/// other classes may use this computation without constructing
		/// a vtkCenterOfMass object.  The scalars can be set to nullptr
		/// if all points are to be weighted equally.  If scalars are
		/// used, it is the caller's responsibility to ensure that the
		/// number of scalars matches the number of points, and that
		/// the sum of the scalars is a positive value.
		/// </summary>
		// Token: 0x06018A09 RID: 100873 RVA: 0x0022692C File Offset: 0x00224B2C
		public static void ComputeCenterOfMass(vtkPoints input, vtkDataArray scalars, IntPtr center)
		{
			vtkCenterOfMass.vtkCenterOfMass_ComputeCenterOfMass_01((input == null) ? default(HandleRef) : input.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), center);
		}

		// Token: 0x06018A0A RID: 100874
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenterOfMass_GetCenter_02(HandleRef pThis);

		/// <summary>
		/// Get the output of the center of mass computation.
		/// </summary>
		// Token: 0x06018A0B RID: 100875 RVA: 0x0022696C File Offset: 0x00224B6C
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCenterOfMass.vtkCenterOfMass_GetCenter_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018A0C RID: 100876
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_GetCenter_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the output of the center of mass computation.
		/// </summary>
		// Token: 0x06018A0D RID: 100877 RVA: 0x002269B4 File Offset: 0x00224BB4
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCenterOfMass.vtkCenterOfMass_GetCenter_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06018A0E RID: 100878
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_GetCenter_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the output of the center of mass computation.
		/// </summary>
		// Token: 0x06018A0F RID: 100879 RVA: 0x002269C6 File Offset: 0x00224BC6
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkCenterOfMass.vtkCenterOfMass_GetCenter_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A10 RID: 100880
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenterOfMass_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A11 RID: 100881 RVA: 0x002269D8 File Offset: 0x00224BD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCenterOfMass.vtkCenterOfMass_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06018A12 RID: 100882
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCenterOfMass_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A13 RID: 100883 RVA: 0x002269F8 File Offset: 0x00224BF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCenterOfMass.vtkCenterOfMass_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06018A14 RID: 100884
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCenterOfMass_GetUseScalarsAsWeights_07(HandleRef pThis);

		/// <summary>
		/// Set a flag to determine if the points are weighted.
		/// </summary>
		// Token: 0x06018A15 RID: 100885 RVA: 0x00226A14 File Offset: 0x00224C14
		public virtual bool GetUseScalarsAsWeights()
		{
			return vtkCenterOfMass.vtkCenterOfMass_GetUseScalarsAsWeights_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06018A16 RID: 100886
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenterOfMass_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A17 RID: 100887 RVA: 0x00226A3C File Offset: 0x00224C3C
		public override int IsA(string type)
		{
			return vtkCenterOfMass.vtkCenterOfMass_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06018A18 RID: 100888
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCenterOfMass_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A19 RID: 100889 RVA: 0x00226A5C File Offset: 0x00224C5C
		public new static int IsTypeOf(string type)
		{
			return vtkCenterOfMass.vtkCenterOfMass_IsTypeOf_09(type);
		}

		// Token: 0x06018A1A RID: 100890
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenterOfMass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A1B RID: 100891 RVA: 0x00226A78 File Offset: 0x00224C78
		public new vtkCenterOfMass NewInstance()
		{
			vtkCenterOfMass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenterOfMass.vtkCenterOfMass_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018A1C RID: 100892
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCenterOfMass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A1D RID: 100893 RVA: 0x00226AD4 File Offset: 0x00224CD4
		public new static vtkCenterOfMass SafeDownCast(vtkObjectBase o)
		{
			vtkCenterOfMass vtkCenterOfMass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCenterOfMass.vtkCenterOfMass_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCenterOfMass = (vtkCenterOfMass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCenterOfMass.Register(null);
				}
			}
			return vtkCenterOfMass;
		}

		// Token: 0x06018A1E RID: 100894
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Get the output of the center of mass computation.
		/// </summary>
		// Token: 0x06018A1F RID: 100895 RVA: 0x00226B53 File Offset: 0x00224D53
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCenterOfMass.vtkCenterOfMass_SetCenter_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018A20 RID: 100896
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_SetCenter_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the output of the center of mass computation.
		/// </summary>
		// Token: 0x06018A21 RID: 100897 RVA: 0x00226B65 File Offset: 0x00224D65
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCenterOfMass.vtkCenterOfMass_SetCenter_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06018A22 RID: 100898
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCenterOfMass_SetUseScalarsAsWeights_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set a flag to determine if the points are weighted.
		/// </summary>
		// Token: 0x06018A23 RID: 100899 RVA: 0x00226B75 File Offset: 0x00224D75
		public virtual void SetUseScalarsAsWeights(bool _arg)
		{
			vtkCenterOfMass.vtkCenterOfMass_SetUseScalarsAsWeights_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B44 RID: 6980
		public new const string MRFullTypeName = "Kitware.VTK.vtkCenterOfMass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B45 RID: 6981
		public new static readonly string MRClassNameKey = "class vtkCenterOfMass";
	}
}
