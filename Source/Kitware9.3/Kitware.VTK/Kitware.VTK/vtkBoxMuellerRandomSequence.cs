using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoxMuellerRandomSequence
	/// </summary>
	/// <remarks>
	///    Gaussian sequence of pseudo random numbers implemented with the Box-Mueller transform
	///
	/// vtkGaussianRandomSequence is a sequence of pseudo random numbers
	/// distributed according to the Gaussian/normal distribution (mean=0 and
	/// standard deviation=1).
	///
	/// It based is calculation from a uniformly distributed pseudo random sequence.
	/// The initial sequence is a vtkMinimalStandardRandomSequence.
	/// </remarks>
	// Token: 0x02000B46 RID: 2886
	public class vtkBoxMuellerRandomSequence : vtkGaussianRandomSequence
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E2BC RID: 123580 RVA: 0x002AADD7 File Offset: 0x002A8FD7
		static vtkBoxMuellerRandomSequence()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxMuellerRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxMuellerRandomSequence"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2BD RID: 123581 RVA: 0x002AADFF File Offset: 0x002A8FFF
		public vtkBoxMuellerRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E2BE RID: 123582
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2BF RID: 123583 RVA: 0x002AAE10 File Offset: 0x002A9010
		public new static vtkBoxMuellerRandomSequence New()
		{
			vtkBoxMuellerRandomSequence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2C0 RID: 123584 RVA: 0x002AAE64 File Offset: 0x002A9064
		public vtkBoxMuellerRandomSequence() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2C1 RID: 123585 RVA: 0x002AAEA8 File Offset: 0x002A90A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E2C2 RID: 123586
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2C3 RID: 123587 RVA: 0x002AAEB4 File Offset: 0x002A90B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601E2C4 RID: 123588
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2C5 RID: 123589 RVA: 0x002AAED4 File Offset: 0x002A90D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601E2C6 RID: 123590
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_GetUniformSequence_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the uniformly distributed sequence of random numbers.
		/// </summary>
		// Token: 0x0601E2C7 RID: 123591 RVA: 0x002AAEF0 File Offset: 0x002A90F0
		public vtkRandomSequence GetUniformSequence()
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetUniformSequence_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomSequence = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomSequence.Register(null);
				}
			}
			return vtkRandomSequence;
		}

		// Token: 0x0601E2C8 RID: 123592
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBoxMuellerRandomSequence_GetValue_04(HandleRef pThis);

		/// <summary>
		/// Current value.
		/// </summary>
		// Token: 0x0601E2C9 RID: 123593 RVA: 0x002AAF60 File Offset: 0x002A9160
		public override double GetValue()
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_GetValue_04(base.GetCppThis());
		}

		// Token: 0x0601E2CA RID: 123594
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxMuellerRandomSequence_Initialize_05(HandleRef pThis, uint arg0);

		/// <summary>
		/// Satisfy general API of vtkRandomSequence superclass. Initialize the
		/// sequence with a seed.
		/// </summary>
		// Token: 0x0601E2CB RID: 123595 RVA: 0x002AAF7F File Offset: 0x002A917F
		public override void Initialize(uint arg0)
		{
			vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_Initialize_05(base.GetCppThis(), arg0);
		}

		// Token: 0x0601E2CC RID: 123596
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxMuellerRandomSequence_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2CD RID: 123597 RVA: 0x002AAF90 File Offset: 0x002A9190
		public override int IsA(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E2CE RID: 123598
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoxMuellerRandomSequence_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2CF RID: 123599 RVA: 0x002AAFB0 File Offset: 0x002A91B0
		public new static int IsTypeOf(string type)
		{
			return vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_IsTypeOf_07(type);
		}

		// Token: 0x0601E2D0 RID: 123600
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2D1 RID: 123601 RVA: 0x002AAFCC File Offset: 0x002A91CC
		public new vtkBoxMuellerRandomSequence NewInstance()
		{
			vtkBoxMuellerRandomSequence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E2D2 RID: 123602
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxMuellerRandomSequence_Next_10(HandleRef pThis);

		/// <summary>
		/// Move to the next number in the random sequence.
		/// </summary>
		// Token: 0x0601E2D3 RID: 123603 RVA: 0x002AB026 File Offset: 0x002A9226
		public override void Next()
		{
			vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_Next_10(base.GetCppThis());
		}

		// Token: 0x0601E2D4 RID: 123604
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoxMuellerRandomSequence_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E2D5 RID: 123605 RVA: 0x002AB038 File Offset: 0x002A9238
		public new static vtkBoxMuellerRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkBoxMuellerRandomSequence vtkBoxMuellerRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxMuellerRandomSequence = (vtkBoxMuellerRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxMuellerRandomSequence.Register(null);
				}
			}
			return vtkBoxMuellerRandomSequence;
		}

		// Token: 0x0601E2D6 RID: 123606
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoxMuellerRandomSequence_SetUniformSequence_12(HandleRef pThis, HandleRef uniformSequence);

		/// <summary>
		/// Set the uniformly distributed sequence of random numbers.
		/// Default is a .
		/// </summary>
		// Token: 0x0601E2D7 RID: 123607 RVA: 0x002AB0B8 File Offset: 0x002A92B8
		public void SetUniformSequence(vtkRandomSequence uniformSequence)
		{
			vtkBoxMuellerRandomSequence.vtkBoxMuellerRandomSequence_SetUniformSequence_12(base.GetCppThis(), (uniformSequence == null) ? default(HandleRef) : uniformSequence.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDF RID: 8159
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxMuellerRandomSequence";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE0 RID: 8160
		public new static readonly string MRClassNameKey = "class vtkBoxMuellerRandomSequence";
	}
}
