using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPoissonDiskSampler
	/// </summary>
	/// <remarks>
	///    generate point normals using local tangent planes
	///
	///
	/// vtkPoissonDiskSampler performs a poisson disk sampling on the input. It takes any `vtkPointSet`
	/// as input and produces a `vtkPointSet`. If the input has cells (typically if the input is a
	/// `vtkPolyData` or a `vtkUnstructuredGrid`), cells are removed in the output point set.
	///
	/// PoissonDisk sampling is done by doing "dart throwing". It is very similar to the implementation
	/// proposed by &lt;a
	/// href="http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.9482&amp;rep=rep1&amp;type=pdf"&gt;
	/// Dipp\'e and Wold in 1986&lt;/a&gt;. Points are drawn randomly one by one and added
	/// in the output. Points within a range of `Radius` (input parameter) are discarded from the
	/// output. This process is repeated until there are no more points unprocessed.
	/// </remarks>
	// Token: 0x02000457 RID: 1111
	public class vtkPoissonDiskSampler : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CED5 RID: 52949 RVA: 0x0011F8FD File Offset: 0x0011DAFD
		static vtkPoissonDiskSampler()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPoissonDiskSampler.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoissonDiskSampler"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CED6 RID: 52950 RVA: 0x0011F925 File Offset: 0x0011DB25
		public vtkPoissonDiskSampler(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CED7 RID: 52951
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoissonDiskSampler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CED8 RID: 52952 RVA: 0x0011F934 File Offset: 0x0011DB34
		public new static vtkPoissonDiskSampler New()
		{
			vtkPoissonDiskSampler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoissonDiskSampler.vtkPoissonDiskSampler_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CED9 RID: 52953 RVA: 0x0011F988 File Offset: 0x0011DB88
		public vtkPoissonDiskSampler() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPoissonDiskSampler.vtkPoissonDiskSampler_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CEDA RID: 52954 RVA: 0x0011F9CC File Offset: 0x0011DBCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CEDB RID: 52955
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoissonDiskSampler_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkKdTreePointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CEDC RID: 52956 RVA: 0x0011F9D8 File Offset: 0x0011DBD8
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoissonDiskSampler.vtkPoissonDiskSampler_GetLocator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600CEDD RID: 52957
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoissonDiskSampler_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEDE RID: 52958 RVA: 0x0011FA48 File Offset: 0x0011DC48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPoissonDiskSampler.vtkPoissonDiskSampler_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CEDF RID: 52959
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoissonDiskSampler_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEE0 RID: 52960 RVA: 0x0011FA68 File Offset: 0x0011DC68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPoissonDiskSampler.vtkPoissonDiskSampler_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CEE1 RID: 52961
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPoissonDiskSampler_GetRadius_04(HandleRef pThis);

		/// <summary>
		/// Setter / Getter for `Radius`. It is used to determinate the minimum distance that there should
		/// be between 2 nearest points in the output.
		/// </summary>
		// Token: 0x0600CEE2 RID: 52962 RVA: 0x0011FA84 File Offset: 0x0011DC84
		public virtual double GetRadius()
		{
			return vtkPoissonDiskSampler.vtkPoissonDiskSampler_GetRadius_04(base.GetCppThis());
		}

		// Token: 0x0600CEE3 RID: 52963
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoissonDiskSampler_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEE4 RID: 52964 RVA: 0x0011FAA4 File Offset: 0x0011DCA4
		public override int IsA(string type)
		{
			return vtkPoissonDiskSampler.vtkPoissonDiskSampler_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600CEE5 RID: 52965
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoissonDiskSampler_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEE6 RID: 52966 RVA: 0x0011FAC4 File Offset: 0x0011DCC4
		public new static int IsTypeOf(string type)
		{
			return vtkPoissonDiskSampler.vtkPoissonDiskSampler_IsTypeOf_06(type);
		}

		// Token: 0x0600CEE7 RID: 52967
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoissonDiskSampler_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEE8 RID: 52968 RVA: 0x0011FAE0 File Offset: 0x0011DCE0
		public new vtkPoissonDiskSampler NewInstance()
		{
			vtkPoissonDiskSampler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoissonDiskSampler.vtkPoissonDiskSampler_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CEE9 RID: 52969
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoissonDiskSampler_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CEEA RID: 52970 RVA: 0x0011FB3C File Offset: 0x0011DD3C
		public new static vtkPoissonDiskSampler SafeDownCast(vtkObjectBase o)
		{
			vtkPoissonDiskSampler vtkPoissonDiskSampler = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoissonDiskSampler.vtkPoissonDiskSampler_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoissonDiskSampler = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoissonDiskSampler.Register(null);
				}
			}
			return vtkPoissonDiskSampler;
		}

		// Token: 0x0600CEEB RID: 52971
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoissonDiskSampler_SetLocator_10(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkKdTreePointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CEEC RID: 52972 RVA: 0x0011FBBC File Offset: 0x0011DDBC
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPoissonDiskSampler.vtkPoissonDiskSampler_SetLocator_10(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CEED RID: 52973
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoissonDiskSampler_SetRadius_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Setter / Getter for `Radius`. It is used to determinate the minimum distance that there should
		/// be between 2 nearest points in the output.
		/// </summary>
		// Token: 0x0600CEEE RID: 52974 RVA: 0x0011FBEB File Offset: 0x0011DDEB
		public virtual void SetRadius(double _arg)
		{
			vtkPoissonDiskSampler.vtkPoissonDiskSampler_SetRadius_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F47 RID: 3911
		public new const string MRFullTypeName = "Kitware.VTK.vtkPoissonDiskSampler";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F48 RID: 3912
		public new static readonly string MRClassNameKey = "class vtkPoissonDiskSampler";
	}
}
