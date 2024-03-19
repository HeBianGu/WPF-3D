using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKMeansDistanceFunctorCalculator
	/// </summary>
	/// <remarks>
	///    measure distance from k-means cluster centers using a user-specified expression
	///
	/// This is a subclass of the default k-means distance functor that allows
	/// the user to specify a distance function as a string. The provided
	/// expression is evaluated whenever the parenthesis operator is invoked
	/// but this is much slower than the default distance calculation.
	///
	/// User-specified distance expressions should be written in terms of
	/// two vector variables named "x" and "y".
	/// The length of the vectors will be determined by the k-means request
	/// and all columns of interest in the request must contain values that
	/// may be converted to a floating point representation. (Strings and
	/// vtkObject pointers are not allowed.)
	/// An example distance expression is "sqrt( (x0-y0)^2 + (x1-y1)^2 )"
	/// which computes Euclidean distance in a plane defined by the first
	/// 2 coordinates of the vectors specified.
	/// </remarks>
	// Token: 0x02000747 RID: 1863
	public class vtkKMeansDistanceFunctorCalculator : vtkKMeansDistanceFunctor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060135E1 RID: 79329 RVA: 0x001B6573 File Offset: 0x001B4773
		static vtkKMeansDistanceFunctorCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansDistanceFunctorCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctorCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060135E2 RID: 79330 RVA: 0x001B659B File Offset: 0x001B479B
		public vtkKMeansDistanceFunctorCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060135E3 RID: 79331
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135E4 RID: 79332 RVA: 0x001B65AC File Offset: 0x001B47AC
		public new static vtkKMeansDistanceFunctorCalculator New()
		{
			vtkKMeansDistanceFunctorCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135E5 RID: 79333 RVA: 0x001B6600 File Offset: 0x001B4800
		public vtkKMeansDistanceFunctorCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060135E6 RID: 79334 RVA: 0x001B6644 File Offset: 0x001B4844
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060135E7 RID: 79335
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(HandleRef pThis);

		/// <summary>
		/// Set/get the distance function expression.
		/// </summary>
		// Token: 0x060135E8 RID: 79336 RVA: 0x001B6650 File Offset: 0x001B4850
		public virtual string GetDistanceExpression()
		{
			string s = Marshal.PtrToStringAnsi(vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060135E9 RID: 79337
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the string containing an expression which evaluates to the
		/// distance metric used for k-means computation. The scalar variables
		/// "x0", "x1", ... "xn" and "y0", "y1", ..., "yn" refer to the coordinates
		/// involved in the computation.
		/// </summary>
		// Token: 0x060135EA RID: 79338 RVA: 0x001B668C File Offset: 0x001B488C
		public virtual vtkFunctionParser GetFunctionParser()
		{
			vtkFunctionParser vtkFunctionParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionParser = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionParser.Register(null);
				}
			}
			return vtkFunctionParser;
		}

		// Token: 0x060135EB RID: 79339
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135EC RID: 79340 RVA: 0x001B66FC File Offset: 0x001B48FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060135ED RID: 79341
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135EE RID: 79342 RVA: 0x001B671C File Offset: 0x001B491C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060135EF RID: 79343
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansDistanceFunctorCalculator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135F0 RID: 79344 RVA: 0x001B6738 File Offset: 0x001B4938
		public override int IsA(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060135F1 RID: 79345
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansDistanceFunctorCalculator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135F2 RID: 79346 RVA: 0x001B6758 File Offset: 0x001B4958
		public new static int IsTypeOf(string type)
		{
			return vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_IsTypeOf_06(type);
		}

		// Token: 0x060135F3 RID: 79347
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135F4 RID: 79348 RVA: 0x001B6774 File Offset: 0x001B4974
		public new vtkKMeansDistanceFunctorCalculator NewInstance()
		{
			vtkKMeansDistanceFunctorCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060135F5 RID: 79349
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135F6 RID: 79350 RVA: 0x001B67D0 File Offset: 0x001B49D0
		public new static vtkKMeansDistanceFunctorCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansDistanceFunctorCalculator vtkKMeansDistanceFunctorCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctorCalculator = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctorCalculator.Register(null);
				}
			}
			return vtkKMeansDistanceFunctorCalculator;
		}

		// Token: 0x060135F7 RID: 79351
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the distance function expression.
		/// </summary>
		// Token: 0x060135F8 RID: 79352 RVA: 0x001B684F File Offset: 0x001B4A4F
		public virtual void SetDistanceExpression(string _arg)
		{
			vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060135F9 RID: 79353
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctorCalculator_SetFunctionParser_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the string containing an expression which evaluates to the
		/// distance metric used for k-means computation. The scalar variables
		/// "x0", "x1", ... "xn" and "y0", "y1", ..., "yn" refer to the coordinates
		/// involved in the computation.
		/// </summary>
		// Token: 0x060135FA RID: 79354 RVA: 0x001B6860 File Offset: 0x001B4A60
		public virtual void SetFunctionParser(vtkFunctionParser arg0)
		{
			vtkKMeansDistanceFunctorCalculator.vtkKMeansDistanceFunctorCalculator_SetFunctionParser_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165E RID: 5726
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctorCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165F RID: 5727
		public new static readonly string MRClassNameKey = "class vtkKMeansDistanceFunctorCalculator";
	}
}
