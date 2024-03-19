using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMersenneTwister
	/// </summary>
	/// <remarks>
	///    Generator for Mersenne Twister pseudorandom numbers
	///
	/// vtkMersenneTwister is an implementation of the Mersenne Twister pseudorandom
	/// number generator. The VTK class is simply a wrapper around an implementation
	/// written by M. Matsumoto, T. Nishimura and M. Saito, whose source code can be
	/// found at http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/DC/dc.html.
	///
	/// This implementation of the Mersenne Twister facilitates the generation and
	/// query from multiple independent pseudorandom sequences. Independent sequences
	/// are identified by a unique vtkMersenneTwister::SequenceId, which is either
	/// generated upon request or passed into the initialization method. This id is
	/// factored into the initialization of the Mersenne Twister's initial state, so
	/// two sequences with the same seed and different sequence ids will produce
	/// different results. Once a sequence is initialized with an associated sequence
	/// id, this id is used to obtain values from the sequence.
	///
	/// This class, besides generating random sequences in sequential order, can
	/// also populate a double array of specified size with a random sequence. It
	/// will do so using one or more threads depending on the number of values
	/// requested to generate.
	/// </remarks>
	// Token: 0x02000B6F RID: 2927
	public class vtkMersenneTwister : vtkRandomSequence
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E962 RID: 125282 RVA: 0x002B5EBB File Offset: 0x002B40BB
		static vtkMersenneTwister()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMersenneTwister.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMersenneTwister"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E963 RID: 125283 RVA: 0x002B5EE3 File Offset: 0x002B40E3
		public vtkMersenneTwister(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E964 RID: 125284
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMersenneTwister_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E965 RID: 125285 RVA: 0x002B5EF4 File Offset: 0x002B40F4
		public new static vtkMersenneTwister New()
		{
			vtkMersenneTwister result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMersenneTwister.vtkMersenneTwister_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E966 RID: 125286 RVA: 0x002B5F48 File Offset: 0x002B4148
		public vtkMersenneTwister() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMersenneTwister.vtkMersenneTwister_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E967 RID: 125287 RVA: 0x002B5F8C File Offset: 0x002B418C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E968 RID: 125288
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMersenneTwister_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E969 RID: 125289 RVA: 0x002B5F98 File Offset: 0x002B4198
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMersenneTwister.vtkMersenneTwister_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601E96A RID: 125290
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMersenneTwister_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E96B RID: 125291 RVA: 0x002B5FB8 File Offset: 0x002B41B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMersenneTwister.vtkMersenneTwister_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601E96C RID: 125292
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMersenneTwister_GetValue_03(HandleRef pThis, uint id);

		/// <summary>
		/// Current value
		/// \post unit_range: result&gt;=0.0 &amp;&amp; result&lt;=1.0
		/// </summary>
		// Token: 0x0601E96D RID: 125293 RVA: 0x002B5FD4 File Offset: 0x002B41D4
		public virtual double GetValue(uint id)
		{
			return vtkMersenneTwister.vtkMersenneTwister_GetValue_03(base.GetCppThis(), id);
		}

		// Token: 0x0601E96E RID: 125294
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMersenneTwister_GetValue_04(HandleRef pThis);

		/// <summary>
		/// Current value
		/// \post unit_range: result&gt;=0.0 &amp;&amp; result&lt;=1.0
		/// </summary>
		// Token: 0x0601E96F RID: 125295 RVA: 0x002B5FF4 File Offset: 0x002B41F4
		public override double GetValue()
		{
			return vtkMersenneTwister.vtkMersenneTwister_GetValue_04(base.GetCppThis());
		}

		// Token: 0x0601E970 RID: 125296
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMersenneTwister_Initialize_05(HandleRef pThis, uint seed);

		/// <summary>
		/// Satisfy general API of vtkRandomSequence superclass. Initialize the
		/// sequence with a seed.
		/// </summary>
		// Token: 0x0601E971 RID: 125297 RVA: 0x002B6013 File Offset: 0x002B4213
		public override void Initialize(uint seed)
		{
			vtkMersenneTwister.vtkMersenneTwister_Initialize_05(base.GetCppThis(), seed);
		}

		// Token: 0x0601E972 RID: 125298
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMersenneTwister_InitializeNewSequence_06(HandleRef pThis, uint seed, int p);

		/// <summary>
		/// Initialize a new Mersenne Twister sequence, given a) a \c seed and b) a
		/// Mersenne exponent (p s.t. 2^p-1 is a Mersenne prime). If \c p is not a
		/// usable Mersenne exponent, its value is used to pick one from a list.
		/// The return value is the id for the generated sequence, which is used as a
		/// key to access values of the sequence.
		/// </summary>
		// Token: 0x0601E973 RID: 125299 RVA: 0x002B6024 File Offset: 0x002B4224
		public uint InitializeNewSequence(uint seed, int p)
		{
			return vtkMersenneTwister.vtkMersenneTwister_InitializeNewSequence_06(base.GetCppThis(), seed, p);
		}

		// Token: 0x0601E974 RID: 125300
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMersenneTwister_InitializeSequence_07(HandleRef pThis, uint id, uint seed, int p);

		/// <summary>
		/// Initialize a sequence as in InitializeNewSequence(), but additionally pass
		/// an id to associate with the new sequence. If a sequence is already
		/// associated with this id, a warning is given and the sequence is reset using
		/// the given parameters.
		/// </summary>
		// Token: 0x0601E975 RID: 125301 RVA: 0x002B6045 File Offset: 0x002B4245
		public void InitializeSequence(uint id, uint seed, int p)
		{
			vtkMersenneTwister.vtkMersenneTwister_InitializeSequence_07(base.GetCppThis(), id, seed, p);
		}

		// Token: 0x0601E976 RID: 125302
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMersenneTwister_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E977 RID: 125303 RVA: 0x002B6058 File Offset: 0x002B4258
		public override int IsA(string type)
		{
			return vtkMersenneTwister.vtkMersenneTwister_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E978 RID: 125304
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMersenneTwister_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E979 RID: 125305 RVA: 0x002B6078 File Offset: 0x002B4278
		public new static int IsTypeOf(string type)
		{
			return vtkMersenneTwister.vtkMersenneTwister_IsTypeOf_09(type);
		}

		// Token: 0x0601E97A RID: 125306
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMersenneTwister_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E97B RID: 125307 RVA: 0x002B6094 File Offset: 0x002B4294
		public new vtkMersenneTwister NewInstance()
		{
			vtkMersenneTwister result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMersenneTwister.vtkMersenneTwister_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E97C RID: 125308
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMersenneTwister_Next_12(HandleRef pThis, uint id);

		/// <summary>
		/// Move to the next number in random sequence \c id. If no sequence is
		/// associated with this id, a warning is given and a sequence is generated
		/// with default values.
		/// </summary>
		// Token: 0x0601E97D RID: 125309 RVA: 0x002B60EE File Offset: 0x002B42EE
		public virtual void Next(uint id)
		{
			vtkMersenneTwister.vtkMersenneTwister_Next_12(base.GetCppThis(), id);
		}

		// Token: 0x0601E97E RID: 125310
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMersenneTwister_Next_13(HandleRef pThis);

		/// <summary>
		/// Move to the next number in random sequence &lt;0&gt;. If no sequence is
		/// associated with this id, a warning is given and a sequence is generated
		/// with default values.
		/// </summary>
		// Token: 0x0601E97F RID: 125311 RVA: 0x002B60FE File Offset: 0x002B42FE
		public override void Next()
		{
			vtkMersenneTwister.vtkMersenneTwister_Next_13(base.GetCppThis());
		}

		// Token: 0x0601E980 RID: 125312
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMersenneTwister_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E981 RID: 125313 RVA: 0x002B6110 File Offset: 0x002B4310
		public new static vtkMersenneTwister SafeDownCast(vtkObjectBase o)
		{
			vtkMersenneTwister vtkMersenneTwister = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMersenneTwister.vtkMersenneTwister_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMersenneTwister = (vtkMersenneTwister)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMersenneTwister.Register(null);
				}
			}
			return vtkMersenneTwister;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020BF RID: 8383
		public new const string MRFullTypeName = "Kitware.VTK.vtkMersenneTwister";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020C0 RID: 8384
		public new static readonly string MRClassNameKey = "class vtkMersenneTwister";
	}
}
