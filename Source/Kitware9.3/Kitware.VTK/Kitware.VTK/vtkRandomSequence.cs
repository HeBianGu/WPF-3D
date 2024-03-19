using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRandomSequence
	/// </summary>
	/// <remarks>
	///    Generate a sequence of random numbers.
	///
	/// vtkRandomSequence defines the interface of any sequence of random numbers.
	///
	/// At this level of abstraction, there is no assumption about the distribution
	/// of the numbers or about the quality of the sequence of numbers to be
	/// statistically independent. There is no assumption about the range of values.
	///
	/// To the question about why a random "sequence" class instead of a random
	/// "generator" class or to a random "number" class?, see the OOSC book:
	/// "Object-Oriented Software Construction", 2nd Edition, by Bertrand Meyer.
	/// chapter 23, "Principles of class design", "Pseudo-random number
	/// generators: a design exercise", page 754--755.
	/// </remarks>
	// Token: 0x02000B44 RID: 2884
	public abstract class vtkRandomSequence : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E292 RID: 123538 RVA: 0x002AAA04 File Offset: 0x002A8C04
		static vtkRandomSequence()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomSequence"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E293 RID: 123539 RVA: 0x002AAA2C File Offset: 0x002A8C2C
		public vtkRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E294 RID: 123540 RVA: 0x002AAA3A File Offset: 0x002A8C3A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E295 RID: 123541
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomSequence_GetNextValue_01(HandleRef pThis);

		/// <summary>
		/// Advance the sequence and return the new value.
		/// </summary>
		// Token: 0x0601E296 RID: 123542 RVA: 0x002AAA48 File Offset: 0x002A8C48
		public double GetNextValue()
		{
			return vtkRandomSequence.vtkRandomSequence_GetNextValue_01(base.GetCppThis());
		}

		// Token: 0x0601E297 RID: 123543
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomSequence_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E298 RID: 123544 RVA: 0x002AAA68 File Offset: 0x002A8C68
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E299 RID: 123545
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomSequence_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E29A RID: 123546 RVA: 0x002AAA88 File Offset: 0x002A8C88
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E29B RID: 123547
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomSequence_GetValue_04(HandleRef pThis);

		/// <summary>
		/// Return the current value.
		/// </summary>
		// Token: 0x0601E29C RID: 123548 RVA: 0x002AAAA4 File Offset: 0x002A8CA4
		public virtual double GetValue()
		{
			return vtkRandomSequence.vtkRandomSequence_GetValue_04(base.GetCppThis());
		}

		// Token: 0x0601E29D RID: 123549
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomSequence_Initialize_05(HandleRef pThis, uint seed);

		/// <summary>
		/// Initialize the sequence with a seed.
		/// </summary>
		// Token: 0x0601E29E RID: 123550 RVA: 0x002AAAC3 File Offset: 0x002A8CC3
		public virtual void Initialize(uint seed)
		{
			vtkRandomSequence.vtkRandomSequence_Initialize_05(base.GetCppThis(), seed);
		}

		// Token: 0x0601E29F RID: 123551
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomSequence_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2A0 RID: 123552 RVA: 0x002AAAD4 File Offset: 0x002A8CD4
		public override int IsA(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E2A1 RID: 123553
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomSequence_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2A2 RID: 123554 RVA: 0x002AAAF4 File Offset: 0x002A8CF4
		public new static int IsTypeOf(string type)
		{
			return vtkRandomSequence.vtkRandomSequence_IsTypeOf_07(type);
		}

		// Token: 0x0601E2A3 RID: 123555
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomSequence_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2A4 RID: 123556 RVA: 0x002AAB10 File Offset: 0x002A8D10
		public new vtkRandomSequence NewInstance()
		{
			vtkRandomSequence result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomSequence.vtkRandomSequence_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E2A5 RID: 123557
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomSequence_Next_09(HandleRef pThis);

		/// <summary>
		/// Move to the next number in the random sequence.
		/// </summary>
		// Token: 0x0601E2A6 RID: 123558 RVA: 0x002AAB6A File Offset: 0x002A8D6A
		public virtual void Next()
		{
			vtkRandomSequence.vtkRandomSequence_Next_09(base.GetCppThis());
		}

		// Token: 0x0601E2A7 RID: 123559
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomSequence_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601E2A8 RID: 123560 RVA: 0x002AAB7C File Offset: 0x002A8D7C
		public new static vtkRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomSequence.vtkRandomSequence_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDB RID: 8155
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomSequence";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDC RID: 8156
		public new static readonly string MRClassNameKey = "class vtkRandomSequence";
	}
}
