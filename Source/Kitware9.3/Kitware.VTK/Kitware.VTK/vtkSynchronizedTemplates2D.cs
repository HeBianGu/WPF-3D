using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSynchronizedTemplates2D
	/// </summary>
	/// <remarks>
	///    generate isoline(s) from a structured points set
	///
	/// vtkSynchronizedTemplates2D is a 2D implementation of the synchronized
	/// template algorithm. Note that vtkContourFilter will automatically
	/// use this class when appropriate.
	///
	/// @warning
	/// This filter is specialized to 2D images.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkFlyingEdges2D vtkMarchingSquares
	/// vtkSynchronizedTemplates3D vtkDiscreteFlyingEdges2D
	/// </seealso>
	// Token: 0x020009AF RID: 2479
	public class vtkSynchronizedTemplates2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019E3B RID: 106043 RVA: 0x0023ED1E File Offset: 0x0023CF1E
		static vtkSynchronizedTemplates2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplates2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplates2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019E3C RID: 106044 RVA: 0x0023ED46 File Offset: 0x0023CF46
		public vtkSynchronizedTemplates2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019E3D RID: 106045
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E3E RID: 106046 RVA: 0x0023ED54 File Offset: 0x0023CF54
		public new static vtkSynchronizedTemplates2D New()
		{
			vtkSynchronizedTemplates2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E3F RID: 106047 RVA: 0x0023EDA8 File Offset: 0x0023CFA8
		public vtkSynchronizedTemplates2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019E40 RID: 106048 RVA: 0x0023EDEC File Offset: 0x0023CFEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019E41 RID: 106049
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_ComputeScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019E42 RID: 106050 RVA: 0x0023EDF7 File Offset: 0x0023CFF7
		public virtual void ComputeScalarsOff()
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_ComputeScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06019E43 RID: 106051
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_ComputeScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019E44 RID: 106052 RVA: 0x0023EE06 File Offset: 0x0023D006
		public virtual void ComputeScalarsOn()
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_ComputeScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06019E45 RID: 106053
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_GenerateValues_03(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019E46 RID: 106054 RVA: 0x0023EE15 File Offset: 0x0023D015
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GenerateValues_03(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06019E47 RID: 106055
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_GenerateValues_04(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019E48 RID: 106056 RVA: 0x0023EE26 File Offset: 0x0023D026
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GenerateValues_04(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06019E49 RID: 106057
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates2D_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019E4A RID: 106058 RVA: 0x0023EE38 File Offset: 0x0023D038
		public virtual int GetArrayComponent()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x06019E4B RID: 106059
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates2D_GetComputeScalars_06(HandleRef pThis);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019E4C RID: 106060 RVA: 0x0023EE58 File Offset: 0x0023D058
		public virtual int GetComputeScalars()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetComputeScalars_06(base.GetCppThis());
		}

		// Token: 0x06019E4D RID: 106061
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSynchronizedTemplates2D_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019E4E RID: 106062 RVA: 0x0023EE78 File Offset: 0x0023D078
		public override ulong GetMTime()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06019E4F RID: 106063
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates2D_GetNumberOfContours_08(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06019E50 RID: 106064 RVA: 0x0023EE98 File Offset: 0x0023D098
		public long GetNumberOfContours()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetNumberOfContours_08(base.GetCppThis());
		}

		// Token: 0x06019E51 RID: 106065
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E52 RID: 106066 RVA: 0x0023EEB8 File Offset: 0x0023D0B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06019E53 RID: 106067
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplates2D_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E54 RID: 106068 RVA: 0x0023EED8 File Offset: 0x0023D0D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06019E55 RID: 106069
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSynchronizedTemplates2D_GetValue_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06019E56 RID: 106070 RVA: 0x0023EEF4 File Offset: 0x0023D0F4
		public double GetValue(int i)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValue_11(base.GetCppThis(), i);
		}

		// Token: 0x06019E57 RID: 106071
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates2D_GetValues_12(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06019E58 RID: 106072 RVA: 0x0023EF14 File Offset: 0x0023D114
		public IntPtr GetValues()
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValues_12(base.GetCppThis());
		}

		// Token: 0x06019E59 RID: 106073
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_GetValues_13(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06019E5A RID: 106074 RVA: 0x0023EF33 File Offset: 0x0023D133
		public void GetValues(IntPtr contourValues)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_GetValues_13(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019E5B RID: 106075
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E5C RID: 106076 RVA: 0x0023EF44 File Offset: 0x0023D144
		public override int IsA(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06019E5D RID: 106077
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplates2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E5E RID: 106078 RVA: 0x0023EF64 File Offset: 0x0023D164
		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_IsTypeOf_15(type);
		}

		// Token: 0x06019E5F RID: 106079
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E60 RID: 106080 RVA: 0x0023EF80 File Offset: 0x0023D180
		public new vtkSynchronizedTemplates2D NewInstance()
		{
			vtkSynchronizedTemplates2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019E61 RID: 106081
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplates2D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019E62 RID: 106082 RVA: 0x0023EFDC File Offset: 0x0023D1DC
		public new static vtkSynchronizedTemplates2D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplates2D vtkSynchronizedTemplates2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplates2D = (vtkSynchronizedTemplates2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplates2D.Register(null);
				}
			}
			return vtkSynchronizedTemplates2D;
		}

		// Token: 0x06019E63 RID: 106083
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_SetArrayComponent_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019E64 RID: 106084 RVA: 0x0023F05B File Offset: 0x0023D25B
		public virtual void SetArrayComponent(int _arg)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetArrayComponent_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E65 RID: 106085
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_SetComputeScalars_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to set the point scalars of the output.  The scalars will be the
		/// iso value of course.  By default this flag is on.
		/// </summary>
		// Token: 0x06019E66 RID: 106086 RVA: 0x0023F06B File Offset: 0x0023D26B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetComputeScalars_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06019E67 RID: 106087
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_SetNumberOfContours_21(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06019E68 RID: 106088 RVA: 0x0023F07B File Offset: 0x0023D27B
		public void SetNumberOfContours(int number)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetNumberOfContours_21(base.GetCppThis(), number);
		}

		// Token: 0x06019E69 RID: 106089
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplates2D_SetValue_22(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x06019E6A RID: 106090 RVA: 0x0023F08B File Offset: 0x0023D28B
		public void SetValue(int i, double value)
		{
			vtkSynchronizedTemplates2D.vtkSynchronizedTemplates2D_SetValue_22(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C21 RID: 7201
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplates2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C22 RID: 7202
		public new static readonly string MRClassNameKey = "class vtkSynchronizedTemplates2D";
	}
}
