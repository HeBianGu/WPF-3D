using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeOrbitLayoutStrategy
	/// </summary>
	/// <remarks>
	///    hierarchical orbital layout
	///
	///
	/// Assigns points to the nodes of a tree to an orbital layout. Each parent
	/// is orbited by its children, recursively.
	///
	/// @par Thanks:
	/// Thanks to the galaxy for inspiring this layout strategy.
	/// </remarks>
	// Token: 0x020002A4 RID: 676
	public class vtkTreeOrbitLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060079D2 RID: 31186 RVA: 0x000AF95B File Offset: 0x000ADB5B
		static vtkTreeOrbitLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeOrbitLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeOrbitLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060079D3 RID: 31187 RVA: 0x000AF983 File Offset: 0x000ADB83
		public vtkTreeOrbitLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060079D4 RID: 31188
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079D5 RID: 31189 RVA: 0x000AF994 File Offset: 0x000ADB94
		public new static vtkTreeOrbitLayoutStrategy New()
		{
			vtkTreeOrbitLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079D6 RID: 31190 RVA: 0x000AF9E8 File Offset: 0x000ADBE8
		public vtkTreeOrbitLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060079D7 RID: 31191 RVA: 0x000AFA2C File Offset: 0x000ADC2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060079D8 RID: 31192
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(HandleRef pThis);

		/// <summary>
		/// This is a magic number right now. Controls the radius
		/// of the child layout, all of this should be fixed at
		/// some point with a more logical layout. Defaults to .5 :)
		/// </summary>
		// Token: 0x060079D9 RID: 31193 RVA: 0x000AFA38 File Offset: 0x000ADC38
		public virtual double GetChildRadiusFactor()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetChildRadiusFactor_01(base.GetCppThis());
		}

		// Token: 0x060079DA RID: 31194
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x060079DB RID: 31195 RVA: 0x000AFA58 File Offset: 0x000ADC58
		public virtual double GetLeafSpacing()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacing_02(base.GetCppThis());
		}

		// Token: 0x060079DC RID: 31196
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x060079DD RID: 31197 RVA: 0x000AFA78 File Offset: 0x000ADC78
		public virtual double GetLeafSpacingMaxValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacingMaxValue_03(base.GetCppThis());
		}

		// Token: 0x060079DE RID: 31198
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x060079DF RID: 31199 RVA: 0x000AFA98 File Offset: 0x000ADC98
		public virtual double GetLeafSpacingMinValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLeafSpacingMinValue_04(base.GetCppThis());
		}

		// Token: 0x060079E0 RID: 31200
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(HandleRef pThis);

		/// <summary>
		/// The spacing of orbital levels. Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x060079E1 RID: 31201 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
		public virtual double GetLogSpacingValue()
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetLogSpacingValue_05(base.GetCppThis());
		}

		// Token: 0x060079E2 RID: 31202
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079E3 RID: 31203 RVA: 0x000AFAD8 File Offset: 0x000ADCD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060079E4 RID: 31204
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079E5 RID: 31205 RVA: 0x000AFAF8 File Offset: 0x000ADCF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060079E6 RID: 31206
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeOrbitLayoutStrategy_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079E7 RID: 31207 RVA: 0x000AFB14 File Offset: 0x000ADD14
		public override int IsA(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060079E8 RID: 31208
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeOrbitLayoutStrategy_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079E9 RID: 31209 RVA: 0x000AFB34 File Offset: 0x000ADD34
		public new static int IsTypeOf(string type)
		{
			return vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_IsTypeOf_09(type);
		}

		// Token: 0x060079EA RID: 31210
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeOrbitLayoutStrategy_Layout_10(HandleRef pThis);

		/// <summary>
		/// Perform the orbital layout.
		/// </summary>
		// Token: 0x060079EB RID: 31211 RVA: 0x000AFB4E File Offset: 0x000ADD4E
		public override void Layout()
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_Layout_10(base.GetCppThis());
		}

		// Token: 0x060079EC RID: 31212
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079ED RID: 31213 RVA: 0x000AFB60 File Offset: 0x000ADD60
		public new vtkTreeOrbitLayoutStrategy NewInstance()
		{
			vtkTreeOrbitLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060079EE RID: 31214
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeOrbitLayoutStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079EF RID: 31215 RVA: 0x000AFBBC File Offset: 0x000ADDBC
		public new static vtkTreeOrbitLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeOrbitLayoutStrategy vtkTreeOrbitLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeOrbitLayoutStrategy = (vtkTreeOrbitLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeOrbitLayoutStrategy.Register(null);
				}
			}
			return vtkTreeOrbitLayoutStrategy;
		}

		// Token: 0x060079F0 RID: 31216
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_14(HandleRef pThis, double _arg);

		/// <summary>
		/// This is a magic number right now. Controls the radius
		/// of the child layout, all of this should be fixed at
		/// some point with a more logical layout. Defaults to .5 :)
		/// </summary>
		// Token: 0x060079F1 RID: 31217 RVA: 0x000AFC3B File Offset: 0x000ADE3B
		public virtual void SetChildRadiusFactor(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetChildRadiusFactor_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060079F2 RID: 31218
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetLeafSpacing_15(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x060079F3 RID: 31219 RVA: 0x000AFC4B File Offset: 0x000ADE4B
		public virtual void SetLeafSpacing(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetLeafSpacing_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060079F4 RID: 31220
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_16(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing of orbital levels. Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x060079F5 RID: 31221 RVA: 0x000AFC5B File Offset: 0x000ADE5B
		public virtual void SetLogSpacingValue(double _arg)
		{
			vtkTreeOrbitLayoutStrategy.vtkTreeOrbitLayoutStrategy_SetLogSpacingValue_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A58 RID: 2648
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeOrbitLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A59 RID: 2649
		public new static readonly string MRClassNameKey = "class vtkTreeOrbitLayoutStrategy";
	}
}
