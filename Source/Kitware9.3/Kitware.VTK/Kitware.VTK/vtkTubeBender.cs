using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkTubeBender
	/// </summary>
	/// <remarks>
	///  Rounds corners on lines for better tubes
	///
	/// vtkTubeBender is designed to generate better tube paths for vtkTubeFilter.
	///
	/// For points with very sharp inflection point angles, the radius used to determine
	/// where surface points are placed becomes more parallel, instead of perpendicular,
	/// to the tube path. This causes the tube to become more oblong, as the
	/// cross-sectional height and width become increasingly disparate.
	///
	/// This filter inserts new points along the tube path near acute angles to reduce
	/// the amount the point normals will change from point to point. This reduces the
	/// cross-sectional height and width variations from over 95% to less than 30%.
	/// This gives an impression of a constant diameter tube with nice acute angle bends
	/// without adding too many new points (and therefore faces).
	///
	///
	/// @warning
	/// Any vtkTubeFilters which use the output of this filter should set UseDefaultNormalOff.
	///
	/// If the path has a relatively large radius and several acute angles in sequence,
	/// the default normal generation can cause tube segments to have a torsional rotation,
	/// along the tube's length which renders as an hourglass instead of a tube. Using
	/// alternate normals correctly renders these hourglass segments as tubes. This problem
	/// may only appear as the radius increases for a given path.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTubeFilter
	/// </seealso>
	// Token: 0x020009BA RID: 2490
	public class vtkTubeBender : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A019 RID: 106521 RVA: 0x00241067 File Offset: 0x0023F267
		static vtkTubeBender()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTubeBender.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTubeBender"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A01A RID: 106522 RVA: 0x0024108F File Offset: 0x0023F28F
		public vtkTubeBender(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A01B RID: 106523
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeBender_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A01C RID: 106524 RVA: 0x002410A0 File Offset: 0x0023F2A0
		public new static vtkTubeBender New()
		{
			vtkTubeBender result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeBender.vtkTubeBender_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A01D RID: 106525 RVA: 0x002410F4 File Offset: 0x0023F2F4
		public vtkTubeBender() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTubeBender.vtkTubeBender_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A01E RID: 106526 RVA: 0x00241138 File Offset: 0x0023F338
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A01F RID: 106527
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTubeBender_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A020 RID: 106528 RVA: 0x00241144 File Offset: 0x0023F344
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTubeBender.vtkTubeBender_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A021 RID: 106529
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTubeBender_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A022 RID: 106530 RVA: 0x00241164 File Offset: 0x0023F364
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTubeBender.vtkTubeBender_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A023 RID: 106531
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeBender_GetRadius_03(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A024 RID: 106532 RVA: 0x00241180 File Offset: 0x0023F380
		public virtual double GetRadius()
		{
			return vtkTubeBender.vtkTubeBender_GetRadius_03(base.GetCppThis());
		}

		// Token: 0x0601A025 RID: 106533
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeBender_GetRadiusMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A026 RID: 106534 RVA: 0x002411A0 File Offset: 0x0023F3A0
		public virtual double GetRadiusMaxValue()
		{
			return vtkTubeBender.vtkTubeBender_GetRadiusMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0601A027 RID: 106535
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTubeBender_GetRadiusMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A028 RID: 106536 RVA: 0x002411C0 File Offset: 0x0023F3C0
		public virtual double GetRadiusMinValue()
		{
			return vtkTubeBender.vtkTubeBender_GetRadiusMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601A029 RID: 106537
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeBender_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A02A RID: 106538 RVA: 0x002411E0 File Offset: 0x0023F3E0
		public override int IsA(string type)
		{
			return vtkTubeBender.vtkTubeBender_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A02B RID: 106539
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTubeBender_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A02C RID: 106540 RVA: 0x00241200 File Offset: 0x0023F400
		public new static int IsTypeOf(string type)
		{
			return vtkTubeBender.vtkTubeBender_IsTypeOf_07(type);
		}

		// Token: 0x0601A02D RID: 106541
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeBender_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A02E RID: 106542 RVA: 0x0024121C File Offset: 0x0023F41C
		public new vtkTubeBender NewInstance()
		{
			vtkTubeBender result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeBender.vtkTubeBender_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A02F RID: 106543
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTubeBender_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A030 RID: 106544 RVA: 0x00241278 File Offset: 0x0023F478
		public new static vtkTubeBender SafeDownCast(vtkObjectBase o)
		{
			vtkTubeBender vtkTubeBender = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTubeBender.vtkTubeBender_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTubeBender = (vtkTubeBender)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTubeBender.Register(null);
				}
			}
			return vtkTubeBender;
		}

		// Token: 0x0601A031 RID: 106545
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTubeBender_SetRadius_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the minimum tube radius (minimum because the tube radius may vary).
		/// </summary>
		// Token: 0x0601A032 RID: 106546 RVA: 0x002412F7 File Offset: 0x0023F4F7
		public virtual void SetRadius(double _arg)
		{
			vtkTubeBender.vtkTubeBender_SetRadius_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3A RID: 7226
		public new const string MRFullTypeName = "Kitware.VTK.vtkTubeBender";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C3B RID: 7227
		public new static readonly string MRClassNameKey = "class vtkTubeBender";
	}
}
