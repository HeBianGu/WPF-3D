using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianRandomSequence
	/// </summary>
	/// <remarks>
	///    Gaussian sequence of pseudo random numbers
	///
	/// vtkGaussianRandomSequence is a sequence of pseudo random numbers
	/// distributed according to the Gaussian/normal distribution (mean=0 and
	/// standard deviation=1)
	///
	/// This is just an interface.
	/// </remarks>
	// Token: 0x02000B45 RID: 2885
	public abstract class vtkGaussianRandomSequence : vtkRandomSequence
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E2A9 RID: 123561 RVA: 0x002AABFB File Offset: 0x002A8DFB
		static vtkGaussianRandomSequence()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianRandomSequence"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2AA RID: 123562 RVA: 0x002AAC23 File Offset: 0x002A8E23
		public vtkGaussianRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2AB RID: 123563 RVA: 0x002AAC31 File Offset: 0x002A8E31
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E2AC RID: 123564
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianRandomSequence_GetNextScaledValue_01(HandleRef pThis, double mean, double standardDeviation);

		/// <summary>
		/// Return the next value in the sequence given the mean and standard
		/// deviation of the Gaussian.
		///
		/// \see vtkGaussianRandomSequence::GetScaledValue
		/// </summary>
		// Token: 0x0601E2AD RID: 123565 RVA: 0x002AAC3C File Offset: 0x002A8E3C
		public double GetNextScaledValue(double mean, double standardDeviation)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_GetNextScaledValue_01(base.GetCppThis(), mean, standardDeviation);
		}

		// Token: 0x0601E2AE RID: 123566
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianRandomSequence_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2AF RID: 123567 RVA: 0x002AAC60 File Offset: 0x002A8E60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E2B0 RID: 123568
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianRandomSequence_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2B1 RID: 123569 RVA: 0x002AAC80 File Offset: 0x002A8E80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E2B2 RID: 123570
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianRandomSequence_GetScaledValue_04(HandleRef pThis, double mean, double standardDeviation);

		/// <summary>
		/// Convenient method to return a value given the mean and standard deviation
		/// of the Gaussian distribution from the Gaussian distribution of mean=0
		/// and standard deviation=1.0. There is an initial implementation that can
		/// be overridden by a subclass.
		/// </summary>
		// Token: 0x0601E2B3 RID: 123571 RVA: 0x002AAC9C File Offset: 0x002A8E9C
		public virtual double GetScaledValue(double mean, double standardDeviation)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_GetScaledValue_04(base.GetCppThis(), mean, standardDeviation);
		}

		// Token: 0x0601E2B4 RID: 123572
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianRandomSequence_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2B5 RID: 123573 RVA: 0x002AACC0 File Offset: 0x002A8EC0
		public override int IsA(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E2B6 RID: 123574
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianRandomSequence_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2B7 RID: 123575 RVA: 0x002AACE0 File Offset: 0x002A8EE0
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_IsTypeOf_06(type);
		}

		// Token: 0x0601E2B8 RID: 123576
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianRandomSequence_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2B9 RID: 123577 RVA: 0x002AACFC File Offset: 0x002A8EFC
		public new vtkGaussianRandomSequence NewInstance()
		{
			vtkGaussianRandomSequence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianRandomSequence.vtkGaussianRandomSequence_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E2BA RID: 123578
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianRandomSequence_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2BB RID: 123579 RVA: 0x002AAD58 File Offset: 0x002A8F58
		public new static vtkGaussianRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianRandomSequence vtkGaussianRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianRandomSequence.vtkGaussianRandomSequence_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianRandomSequence = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianRandomSequence.Register(null);
				}
			}
			return vtkGaussianRandomSequence;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDD RID: 8157
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianRandomSequence";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDE RID: 8158
		public new static readonly string MRClassNameKey = "class vtkGaussianRandomSequence";
	}
}
